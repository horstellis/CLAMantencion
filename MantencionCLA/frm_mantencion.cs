using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MantencionCLA
{
    public partial class frm_mantencion : Form
    {
        private auxiliar aux = new auxiliar();
        private sql sql = new sql();
        private static String usuario = util.getInicio().ver_usuario();
        private int fila = 0, id_detalle = 0;
        private String detalle = "";
        private int seccion = 0, solicitante = 0, solicitud = 0, mantencion = 0, linea = 0, maquina = 0, clasificacion = 0;
        private int id_estado_mantencion = 0, responsable = 0;
        private String limite = "", inicio = "", termino = "", real = "";

        public frm_mantencion()
        {
            InitializeComponent();
        }

        private void frm_mantencion_Load(object sender, EventArgs e)
        {
            lbl_factual.Text = DateTime.Today.ToLongDateString().Substring(0, 1).ToUpper() + DateTime.Today.ToLongDateString().Substring(1);
            try
            {
                sql.llenar_combo(cmb_seccion, "SELECT * FROM seccion ORDER BY nombre", "seccion", "nombre", "id_seccion");
                sql.llenar_combo(cmb_solicitante, "SELECT * FROM solicitante ORDER BY nombre", "solicitante", "nombre", "id_solicitante");
                sql.llenar_combo(cmb_clasificacion, "SELECT * FROM clasificacion ORDER BY nombre", "clasificacion", "nombre", "id_clasificacion");
                sql.llenar_combo(cmb_responsable, "SELECT * FROM responsable WHERE id_estado = 1 ORDER BY nombre", "responsable", "nombre", "id_responsable");
                sql.llenar_combo(cmb_ver_seccion, "SELECT * FROM seccion ORDER BY nombre", "seccion", "nombre", "id_seccion");
                reinicia_valores();
                opt_ver_solicitud.PerformClick();
                opt_ver_sec_todas.PerformClick();
                opt_ver_anio_todos.PerformClick();
            }
            catch (Exception ex)
            {
                util.getMenu().setMsgError(ex.Message);
            }
        }

        private void frm_mantencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setMantencion(null);
            this.Dispose();
        }

        private void opt_si_Click(object sender, EventArgs e)
        {
            lst_ayudante.DataSource = null;
            lst_ayudante.Items.Clear();
            try
            {
                if (cmb_responsable.SelectedIndex != -1)
                {
                    int id = int.Parse(cmb_responsable.SelectedValue.ToString());
                    sql.llenar_lista(lst_ayudante, "SELECT * FROM responsable WHERE id_responsable <> " + id + "ORDER BY nombre", "responsable", "nombre", "id_responsable");
                }
                lst_ayudante.Enabled = true;
            }
            catch { }
        }

        private void opt_no_Click(object sender, EventArgs e)
        {
            lst_ayudante.Enabled = false;
            lst_ayudante.DataSource = null;
            lst_ayudante.Items.Clear();
        }

        public void carga_combos(int id)
        {
            try
            {
                sql.llenar_combo(cmb_linea, "SELECT * FROM linea WHERE id_seccion = " + id + " ORDER BY nombre", "linea", "nombre", "id_linea");
                sql.llenar_combo(cmb_maquina, "SELECT * FROM maquina WHERE id_seccion = " + id + " ORDER BY nombre", "maquina", "nombre", "id_maquina");
                cmb_linea.SelectedIndex = -1;
                cmb_maquina.SelectedIndex = -1;
            }
            catch { }
        }

        private void cmb_seccion_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cmb_seccion.SelectedValue.ToString());
                carga_combos(id);
            }
            catch { }
        }

        private void cmb_responsable_DropDown(object sender, EventArgs e)
        {
            opt_no.PerformClick();
        }

        private void mostrar_fecha(DateTimePicker dtp, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    dtp.Format = DateTimePickerFormat.Short;
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    dtp.Format = DateTimePickerFormat.Custom;
                    dtp.CustomFormat = " ";
                    break;
            }
        }

        private Boolean valida_campos()
        {
            if (cmb_clasificacion.SelectedIndex == -1)
            {
                aux.dialogo("Debe de indicar Clasificación", this.Text, 3);
                return false;
            }
            else if (!opt_pendiente.Checked && !opt_finalizado.Checked)
            {
                aux.dialogo("Debe indicar Estado Actividad", this.Text, 3);
                return false;
            }
            else if (cmb_responsable.SelectedIndex!=-1 && dtp_flimite.Format == DateTimePickerFormat.Custom)
            {
                aux.dialogo("Debe indicar fecha de Límite de Mantención", this.Text, 3);
                return false;
            }
            else if (opt_finalizado.Checked && dtp_freal.Format == DateTimePickerFormat.Custom)
            {
                aux.dialogo("Debe indicar fecha de Término Real antes de dar por finalizada la actividad", this.Text, 3);
                return false;
            }
            else if (txt_solicitud.Enabled)
            {
                if (dtp_fsolicitud.Format == DateTimePickerFormat.Custom)
                {
                    aux.dialogo("Debe establecer fecha de Solicitud", this.Text, 3);
                    return false;
                }
                else if (cmb_solicitante.SelectedIndex == -1)
                {
                    aux.dialogo("Debe de indicar Solicitante", this.Text, 3);
                    return false;
                }
                else if (cmb_seccion.SelectedIndex == -1)
                {
                    aux.dialogo("Debe de indicar Sección", this.Text, 3);
                    return false;
                }
                else if (txt_detalle.Text.Trim().Length == 0)
                {
                    aux.dialogo("Debe de indicar Descripción del Problema", this.Text, 3);
                    txt_detalle.Focus();
                    return false;
                }
                else if (txt_detalle.Text.Trim().Length < 10)
                {
                    aux.dialogo("Descripción del Problema debe tener como mínimo 10 caracteres", this.Text, 3);
                    txt_detalle.SelectAll();
                    txt_detalle.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private void cmd_insertar_Click(object sender, EventArgs e)
        {
            if (valida_campos())
            {
                String mensaje = "";
                solicitante = int.Parse(cmb_solicitante.SelectedValue.ToString());
                seccion = int.Parse(cmb_seccion.SelectedValue.ToString());
                clasificacion = int.Parse(cmb_clasificacion.SelectedValue.ToString());
                if (opt_pendiente.Checked) id_estado_mantencion = 1;
                if (opt_finalizado.Checked) id_estado_mantencion = 2;
                try
                {
                    linea = int.Parse(cmb_linea.SelectedValue.ToString());
                }
                catch { }
                try
                {
                    maquina = int.Parse(cmb_maquina.SelectedValue.ToString());
                }
                catch { }
                try
                {
                    responsable = int.Parse(cmb_responsable.SelectedValue.ToString());
                }
                catch { }
                if (dtp_flimite.Format == DateTimePickerFormat.Short) limite = dtp_flimite.Value.ToShortDateString();
                if (dtp_finicio.Format == DateTimePickerFormat.Short) inicio = dtp_finicio.Value.ToShortDateString();
                if (dtp_ftermino.Format == DateTimePickerFormat.Short) termino = dtp_ftermino.Value.ToShortDateString();
                if (dtp_freal.Format == DateTimePickerFormat.Short) real = dtp_freal.Value.ToShortDateString();
                
                //Antes: validar las fechas
                if (dtp_flimite.Format == DateTimePickerFormat.Short)
                {
                    if (dtp_finicio.Format == DateTimePickerFormat.Short)
                    {
                        if (dtp_finicio.Value > dtp_flimite.Value)
                        {
                            aux.dialogo("Fecha de Inicio Programado debe ser menor\no igual a la Límite", this.Text, 3);
                            dtp_finicio.Focus();
                            return;
                        }
                        else
                        {
                            if (dtp_ftermino.Format == DateTimePickerFormat.Short)
                            {
                                if (dtp_ftermino.Value < dtp_finicio.Value)
                                {
                                    aux.dialogo("Fecha de Término Programado debe ser mayor\no igual a la de Inicio Programado", this.Text, 3);
                                    dtp_ftermino.Focus();
                                    return;
                                }
                                else if (dtp_ftermino.Value > dtp_flimite.Value)
                                {
                                    aux.dialogo("Fecha de Término Programado debe ser menor\no igual a la Límite", this.Text, 3);
                                    dtp_ftermino.Focus();
                                    return;
                                }
                            }
                        }
                    }
                    else if (dtp_ftermino.Format == DateTimePickerFormat.Short)
                    {
                        if (dtp_ftermino.Value > dtp_flimite.Value)
                        {
                            aux.dialogo("Fecha de Término Programado debe ser menor\no igual a la Límite", this.Text, 3);
                            dtp_ftermino.Focus();
                            return;
                        }
                    }
                }
                else if (dtp_finicio.Format == DateTimePickerFormat.Short)
                {
                    if (dtp_ftermino.Format == DateTimePickerFormat.Short)
                    {
                        if (dtp_ftermino.Value < dtp_finicio.Value)
                        {
                            aux.dialogo("Fecha de Término Programado debe ser mayor\no igual a la de Inicio Programado", this.Text, 3);
                            dtp_ftermino.Focus();
                            return;
                        }
                    }
                }

                //Primero: se verifica si hay solicitud cargada, sino la intentara guardar
                if (txt_solicitud.Text.Length == 0)
                {
                    int num = 0;
                    if (txt_folio.Text.Length > 0)
                    {
                        num = int.Parse(txt_folio.Text);
                    }
                    SqlDataReader folio = sql.consulta("SELECT * FROM solicitud_folio WHERE folio = " + num);
                    if (folio.Read())
                    {
                        aux.dialogo("No se puede duplicar numero de folio", this.Text, 3);
                        txt_folio.SelectAll();
                        txt_folio.Focus();
                        return;
                    }
                    else
                    {
                        //Inserta nuevo dato
                        String query = "EXEC ingresar_solicitud 0,";
                        query += num + ",";
                        query += "'" + dtp_fsolicitud.Value.ToShortDateString() + "',";
                        query += "'" + txt_detalle.Text + "',";
                        query += seccion + ",";
                        query += solicitante + ",'";
                        query += usuario + "'";
                        int exec = sql.ejecutar(query);
                        if (exec > 0)
                        {
                            mensaje = "Solicitud ingresada correctamente";
                            SqlDataReader sol = sql.consulta("SELECT TOP 1 id_solicitud FROM solicitud ORDER BY id_solicitud DESC");
                            sol.Read();
                            solicitud = sol.GetInt32(0);
                            txt_solicitud.Text = solicitud.ToString();
                            sol.Dispose();
                        }
                        else
                        {
                            aux.dialogo("No se pudo ingresar la solicitud", this.Text, 3);
                            return;
                        }
                    }
                    folio.Dispose();
                }
                else
                {
                    solicitud = int.Parse(txt_solicitud.Text);
                }

                //Segundo: guardara o actualizara la mantencion
                SqlDataReader mant = sql.consulta("SELECT id_mantencion FROM mantencion WHERE id_solicitud = " + solicitud);
                if (mant.Read())
                {
                    mantencion = mant.GetInt32(0);
                }
                mant.Dispose();
                if (mantencion == 0)
                {
                    String consulta = "EXEC ingresar_mantencion ";
                    consulta += mantencion + ",";
                    consulta += solicitud + ",";
                    consulta += clasificacion + ",";
                    consulta += id_estado_mantencion + ",";
                    consulta += linea + ",";
                    consulta += maquina + ",";
                    consulta += responsable + ",'";
                    consulta += limite + "','";
                    consulta += inicio + "','";
                    consulta += termino + "','";
                    consulta += real + "','";
                    consulta += usuario + "'";
                    if (sql.ejecutar(consulta) > 0)
                    {
                        if (mensaje.Length > 0)
                        {
                            mensaje += ".\nMantención agregada exitosamente";
                            SqlDataReader m = sql.consulta("SELECT id_mantencion FROM mantencion WHERE id_solicitud = " + solicitud);
                            m.Read();
                            mantencion = m.GetInt32(0);
                            m.Dispose();
                        }
                        else
                        {
                            mensaje = "Mantención agregada exitosamente";
                        }
                    }
                    else
                    {
                        mensaje += ",\npero no se pudo agregar la mantención\nIntente nuevamente.";
                        aux.dialogo(mensaje, this.Text, 3);
                        return;
                    }
                }
                else if (aux.dialogo("¿Desea actualizar la mantención activa?", this.Text, 1) == DialogResult.Yes)
                {
                    String consulta = "EXEC ingresar_mantencion ";
                    consulta += mantencion + ",";
                    consulta += solicitud + ",";
                    consulta += clasificacion + ",";
                    consulta += id_estado_mantencion + ",";
                    consulta += linea + ",";
                    consulta += maquina + ",";
                    consulta += responsable + ",'";
                    consulta += limite + "','";
                    consulta += inicio + "','";
                    consulta += termino + "','";
                    consulta += real + "','";
                    consulta += usuario + "'";
                    if (sql.ejecutar(consulta) > 0)
                    {
                        mensaje += "Mantención actualizada exitosamente";
                    }
                    else
                    {
                        aux.dialogo("No se pudo actualizar la mantención", this.Text, 3);
                        return;
                    }
                }

                //Tercero: se revisra si es posible modificar o eliminar la maquina asociada
                if (sql.verificar("SELECT * FROM mantencion_maquina WHERE id_mantencion = " + mantencion))
                {
                    SqlDataReader mma = sql.consulta("SELECT id_mantencion_maquina FROM mantencion_maquina WHERE id_mantencion = " + mantencion);
                    mma.Read();
                    int auxmma = mma.GetInt32(0);
                    if (!sql.verificar("SELECT * FROM mantencion_maquina_articulo WHERE id_mantencion_maquina = " + auxmma))
                    {
                        //si no existe articulos para la mantencion de maquina, es posible modificar o eliminar
                        if (cmb_maquina.SelectedIndex != -1)
                        {
                            if ((sql.ejecutar("UPDATE mantencion_maquina SET id_maquina = " + maquina + " WHERE id_mantencion_maquina = " + auxmma)) > 0)
                            {
                                mensaje += "\nSe actualizo correctamente la máquina asociada";
                            }
                            else
                            {
                                mensaje += "\nNo se pudo actualizar la máquina asociada";
                                aux.dialogo(mensaje, this.Text, 3);
                                return;
                            }
                        }
                        else
                        {
                            if ((sql.ejecutar("DELETE FROM mantencion_maquina WHERE id_mantencion_maquina = " + auxmma)) > 0)
                            {
                                mensaje += "\nSe elimino correctamente la máquina asociada";
                            }
                            else
                            {
                                mensaje += "\nNo fue posible eliminar la máquina asociada";
                                aux.dialogo(mensaje, this.Text, 3);
                                return;
                            }
                        }
                    }
                }

                //Cuarto: se revisara si hay ayudantes y se guardaran en caso de existir
                if (responsable > 0)
                {
                    if (sql.verificar("SELECT * FROM responsable_asignado WHERE id_mantencion = " + mantencion + " AND id_responsable = " + responsable))
                    {
                        if (sql.ejecutar("UPDATE responsable_asignado SET id_responsable = " + responsable + " WHERE id_mantencion = " + mantencion + " AND id_asignacion = 1") > 0)
                        {
                            if (opt_si.Checked)
                            {
                                for (int i = 0; i < lst_ayudante.Items.Count; i++)
                                {
                                    if (lst_ayudante.GetItemChecked(i))
                                    {
                                        lst_ayudante.SetSelected(i, true);
                                        SqlDataReader id = sql.consulta("SELECT id_responsable FROM responsable WHERE nombre = '" + lst_ayudante.SelectedValue.ToString() + "'");
                                        id.Read();
                                        responsable = id.GetInt32(0);
                                        sql.ejecutar("INSERT INTO responsable_asignado(id_mantencion,id_responsable,id_asignacion) VALUES (" + mantencion + "," + responsable + ",2)");
                                        id.Dispose();
                                    }
                                }
                            }
                            else
                            {
                                if (sql.verificar("SELECT * FROM responsable_asignado WHERE id_mantencion = " + mantencion + " AND id_asignacion = 2"))
                                {
                                    sql.ejecutar("DELETE FROM responsable_asignado WHERE id_mantencion = " + mantencion + " AND id_asignacion = 2");
                                }
                            }
                        }
                        else
                        {
                            mensaje += "\nNo se pudo actualizar el responsable";
                            aux.dialogo(mensaje, this.Text, 3);
                            return;
                        }
                    }
                }
                else
                {
                    if (sql.verificar("SELECT * FROM responsable_asignado WHERE id_mantencion = " + mantencion))
                    {
                        if (sql.ejecutar("DELETE FROM responsable_asignado WHERE id_mantencion = " + mantencion) > 0)
                        {
                            mensaje += "\nSe eliminaron todos los responsables.";
                        }
                        else
                        {
                            mensaje += "\nNo se pudieron eliminar los responsables.";
                            aux.dialogo(mensaje, this.Text, 3);
                            return;
                        }
                    }
                }
                //Quinto: se establecera si se agregan o modifican observaciones
                if (dat_observaciones.Rows.Count > 1)
                {
                    int a = 0;
                    for (int i = 0; i < dat_observaciones.Rows.Count; i++)
                    {
                        String query = "";
                        DataGridViewRow fila = dat_observaciones.Rows[i];
                        if (!fila.IsNewRow)
                        {
                            if (sql.verificar("SELECT * FROM det_mantencion WHERE id_det_mantencion = " + fila.Cells[0].Value.ToString()))
                            {
                                query = "UPDATE det_mantencion SET ";
                                query += "fecha = '" + fila.Cells[1].Value.ToString() + "', ";
                                query += "observacion='" + fila.Cells[2].Value.ToString() + "' ";
                                query += "WHERE id_det_mantencion = " + fila.Cells[0].Value.ToString();
                            }
                            else
                            {
                                query = "INSERT INTO det_mantencion(id_mantencion,fecha,observacion) VALUES(";
                                query += mantencion + ",'";
                                query += fila.Cells[1].Value.ToString() + "','";
                                query += fila.Cells[2].Value.ToString() + "')";
                            }
                            if (sql.ejecutar(query) > 0)
                            {
                                a++;
                            }
                        }
                    }
                    if (a > 0)
                    {
                        mensaje += "\nObservaciones ingresadas correctamente";
                    }
                    else
                    {
                        mensaje += "\nNo se pudieron ingresar observaciones";
                        aux.dialogo(mensaje, this.Text, 3);
                        return;
                    }
                }

                if (mensaje.Length > 0)
                {
                    aux.dialogo(mensaje, this.Text, 2);
                }
            }
        }

        private void reinicia_valores()
        {
            solicitante = 0; seccion = 0; maquina = 0; linea = 0; solicitud = 0; mantencion = 0; clasificacion = 0;
            fila = 0; id_detalle = 0; detalle = "";
            limite = ""; inicio = ""; termino = ""; real = "";
            txt_solicitud.Clear();
            txt_folio.Clear();
            cmb_seccion.SelectedIndex = -1;
            cmb_linea.DataSource = null;
            cmb_maquina.DataSource = null;
            cmb_solicitante.SelectedIndex = -1;
            cmb_clasificacion.SelectedIndex = -1;
            txt_detalle.Clear();
            cmb_responsable.SelectedIndex = -1;
            opt_pendiente.Checked = false;
            opt_finalizado.Checked = false;
            dtp_fsolicitud.Value = DateTime.Today;
            dtp_flimite.Value = DateTime.Today;
            dtp_finicio.Value = DateTime.Today;
            dtp_ftermino.Value = DateTime.Today;
            dtp_freal.Value = DateTime.Today;
            dtp_fsolicitud.Format = DateTimePickerFormat.Custom;
            dtp_flimite.Format = DateTimePickerFormat.Custom;
            dtp_finicio.Format = DateTimePickerFormat.Custom;
            dtp_ftermino.Format = DateTimePickerFormat.Custom;
            dtp_freal.Format = DateTimePickerFormat.Custom;
            opt_no.Checked = true;
            opt_no.PerformClick();
            dat_observaciones.Rows.Clear();
            dat_observaciones.Refresh();
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            habilitar_solicitud(true);
        }

        private void habilitar_solicitud(Boolean b)
        {
            txt_solicitud.Enabled = b;
            txt_folio.Enabled = b;
            dtp_fsolicitud.Enabled = b;
            cmb_seccion.Enabled = b;
            cmb_solicitante.Enabled = b;
            txt_detalle.Enabled = b;
        }

        private void cmd_limpiar_Click(object sender, EventArgs e)
        {
            reinicia_valores();
        }

        private void cmd_buscar_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            String consulta = "";
            SqlDataReader lector;
            int id_seccion = 0, anio = 0, op = 0;
            if (cmb_ver_seccion.SelectedIndex != -1)
            {
                id_seccion = int.Parse(cmb_ver_seccion.SelectedValue.ToString());
            }
            if (txt_ver_anio.Text.Length == 4)
            {
                anio = int.Parse(txt_ver_anio.Text);
            }
            //Inicia evaluaciones de condiciones para construccion de consulta
            if (opt_ver_solicitud.Checked)
            {
                consulta = "EXEC buscar_solicitud " + id_seccion + "," + anio;
                op = 1;
            }
            else if (opt_ver_sin_asignar.Checked)
            {
                consulta = "EXEC buscar_sin_asignar " + id_seccion;
            }
            else if (opt_ver_pendientes.Checked)
            {
                consulta = "EXEC buscar_pendiente " + id_seccion + "," + anio;
            }
            else if (opt_ver_por_vencer.Checked)
            {
                consulta = "EXEC buscar_por_vencer " + id_seccion;
            }
            else if (opt_ver_vencidas.Checked)
            {
                consulta = "EXEC buscar_vencidas " + id_seccion;
            }
            else if (opt_ver_finalizadas.Checked)
            {
                consulta = "EXEC buscar_finalizada " + id_seccion + "," + anio;
            }
            else
            {
                aux.dialogo("Debe de seleccionar un Tipo Búsqueda", this.Text, 3);
            }
            //Ejecuta la consulta seleccionada y muestra los resultados en la grilla
            lector = sql.consulta(consulta);
            while (lector.Read())
            {
                String ftermino = "", flimite = "";
                switch (op)
                {
                    case 0:
                        try // evalua si existe fecha termino
                        {
                            ftermino = lector.GetDateTime(2).ToShortDateString();
                        }
                        catch { /*deja en blanco la variable*/ }
                        try // evalua si existe fecha limite
                        {
                            flimite = lector.GetDateTime(3).ToShortDateString();
                        }
                        catch { /*deja en blanco la variable*/ }
                        dat_ver.Rows.Add(lector.GetInt32(0), lector.GetString(1), ftermino, flimite);
                        break;
                    case 1:
                        dat_ver.Rows.Add(lector.GetInt32(0), lector.GetString(1), lector.GetDateTime(2).ToShortDateString(), lector.GetString(3));
                        break;
                }
            }
        }

        private void cmd_asignar_articulos_Click(object sender, EventArgs e)
        {
            if (txt_solicitud.Text.Length > 0)
            {
                SqlDataReader mant = sql.consulta("SELECT id_mantencion FROM mantencion WHERE id_solicitud = "+txt_solicitud.Text);
                if(mant.Read())
                {
                    mantencion = mant.GetInt32(0);
                }
                mant.Dispose();
                maquina = int.Parse(cmb_maquina.SelectedValue.ToString());
                if (mantencion != 0)
                {
                    if (sql.verificar("SELECT * FROM mantencion_maquina WHERE id_mantencion = " + mantencion + " AND id_maquina = " + maquina))
                    {
                        frm_articulos_mantencion articulos = new frm_articulos_mantencion();
                        articulos.mantencion = mantencion;
                        articulos.maquina = maquina;
                        articulos.lbl_solicitud.Text = txt_solicitud.Text;
                        articulos.lbl_maquina.Text = cmb_maquina.Text;
                        articulos.ShowDialog(this);
                    }
                    else
                    {
                        aux.dialogo("No existe asociación entre Máquina seleccionada y mantención seleccionada", this.Text, 3);
                    }
                }
                else
                {
                    aux.dialogo("Solicitud no esta asociada a una Mantención", this.Text, 3);
                }
            }
            else
            {
                aux.dialogo("Debe eligir una actividad antes", this.Text, 3);
            }
        }

        private void opt_ver_sec_todas_Click(object sender, EventArgs e)
        {
            cmb_ver_seccion.SelectedIndex = -1;
            cmb_ver_seccion.Enabled = false;
        }

        private void opt_ver_sec_una_Click(object sender, EventArgs e)
        {
            cmb_ver_seccion.Enabled = true;
        }

        private void opt_ver_anio_todos_Click(object sender, EventArgs e)
        {
            txt_ver_anio.Clear();
            txt_ver_anio.Enabled = false;
        }

        private void opt_ver_anio_anio_Click(object sender, EventArgs e)
        {
            txt_ver_anio.Enabled = true;
        }

        private void dtp_fsolicitud_MouseDown(object sender, MouseEventArgs e)
        {
            mostrar_fecha(dtp_fsolicitud, e);
        }

        private void dtp_flimite_MouseDown(object sender, MouseEventArgs e)
        {
            mostrar_fecha(dtp_flimite, e);
        }

        private void dtp_finicio_MouseDown(object sender, MouseEventArgs e)
        {
            mostrar_fecha(dtp_finicio, e);
        }

        private void dtp_ftermino_MouseDown(object sender, MouseEventArgs e)
        {
            mostrar_fecha(dtp_ftermino, e);
        }

        private void dtp_freal_MouseDown(object sender, MouseEventArgs e)
        {
            mostrar_fecha(dtp_freal, e);
        }

        private void opt_ver_solicitud_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            dat_ver.Columns[2].HeaderText = "Solicitud";
            dat_ver.Columns[3].HeaderText = "Solicitante";
            dat_ver.Columns[3].Width = 100;
            opt_ver_sec_todas.PerformClick();
            opt_ver_anio_todos.PerformClick();
            fra_anio.Enabled = true;
        }

        private void opt_ver_sin_asignar_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            dat_ver.Columns[2].HeaderText = "Término";
            dat_ver.Columns[3].HeaderText = "Límite";
            dat_ver.Columns[3].Width = 70;
            opt_ver_sec_todas.PerformClick();
            opt_ver_anio_todos.PerformClick();
            fra_anio.Enabled = false;
        }

        private void opt_ver_pendientes_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            dat_ver.Columns[2].HeaderText = "Término";
            dat_ver.Columns[3].HeaderText = "Límite";
            dat_ver.Columns[3].Width = 70;
            opt_ver_sec_todas.PerformClick();
            opt_ver_anio_todos.PerformClick();
            fra_anio.Enabled = true;
        }

        private void opt_ver_por_vencer_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            dat_ver.Columns[2].HeaderText = "Término";
            dat_ver.Columns[3].HeaderText = "Límite";
            dat_ver.Columns[3].Width = 70;
            opt_ver_sec_todas.PerformClick();
            opt_ver_anio_todos.PerformClick();
            fra_anio.Enabled = false;
        }

        private void opt_ver_vencidas_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            dat_ver.Columns[2].HeaderText = "Término";
            dat_ver.Columns[3].HeaderText = "Límite";
            dat_ver.Columns[3].Width = 70;
            opt_ver_sec_todas.PerformClick();
            opt_ver_anio_todos.PerformClick();
            fra_anio.Enabled = false;
        }

        private void opt_ver_finalizadas_Click(object sender, EventArgs e)
        {
            dat_ver.Rows.Clear();
            dat_ver.Refresh();
            dat_ver.Columns[2].HeaderText = "Término";
            dat_ver.Columns[3].HeaderText = "Límite";
            dat_ver.Columns[3].Width = 70;
            opt_ver_sec_todas.PerformClick();
            opt_ver_anio_todos.PerformClick();
            fra_anio.Enabled = true;
        }

        private void txt_ver_anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 1);
        }

        private void dat_ver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                buscar(int.Parse(dat_ver.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
            catch { }
        }

        private void buscar(int id_solicitud)
        {
            try
            {
                if (sql.verificar("SELECT * FROM solicitud WHERE id_solicitud = " + id_solicitud))
                {
                    reinicia_valores();
                    //Primero: se cargan los datos de la solicitud
                    SqlDataReader l1 = sql.consulta("SELECT * FROM solicitud WHERE id_solicitud = " + id_solicitud);
                    l1.Read();
                    txt_solicitud.Text = id_solicitud.ToString();
                    dtp_fsolicitud.Format = DateTimePickerFormat.Short;
                    dtp_fsolicitud.Value = l1.GetDateTime(1);
                    txt_detalle.Text = l1.GetString(2);
                    cmb_seccion.SelectedValue = l1.GetInt32(3);
                    cmb_solicitante.SelectedValue = l1.GetInt32(4);
                    carga_combos(l1.GetInt32(3));
                    SqlDataReader l2 = sql.consulta("SELECT folio FROM solicitud_folio WHERE id_solicitud = " + id_solicitud);
                    if (l2.Read())
                    {
                        txt_folio.Text = l2.GetInt32(0).ToString();
                    }
                    //Segundo: se evalua si hay mantencion asociada y se carga en caso que si
                    if (sql.verificar("SELECT * FROM mantencion WHERE id_solicitud = " + id_solicitud))
                    {
                        SqlDataReader l3 = sql.consulta("SELECT * FROM mantencion WHERE id_solicitud = " + id_solicitud);
                        l3.Read();
                        int mant = l3.GetInt32(0);
                        mantencion = l3.GetInt32(0);
                        cmb_clasificacion.SelectedValue = l3.GetInt32(2);
                        int estado = l3.GetInt32(3);
                        if (estado == 3)
                        {
                            reinicia_valores();
                            aux.dialogo("Actividad fue marcada como eliminada", this.Text, 3);
                            return;
                        }
                        else if (estado == 1)
                        {
                            opt_pendiente.Checked = true;
                        }
                        else if (estado == 2)
                        {
                            opt_finalizado.Checked = true;
                        }
                        //Tercero: se evalua si existen linea o maquina asociada
                        SqlDataReader l4 = sql.consulta("SELECT id_linea FROM mantencion_linea WHERE id_mantencion = " + mant);
                        if (l4.Read())
                        {
                            cmb_linea.SelectedValue = l4.GetInt32(0);
                        }
                        SqlDataReader l5 = sql.consulta("SELECT id_maquina FROM mantencion_maquina WHERE id_mantencion = " + mant);
                        if (l5.Read())
                        {
                            cmb_maquina.SelectedValue = l5.GetInt32(0);
                        }
                        //Cuarto: se evalua si hay responsables asignados
                        SqlDataReader l6 = sql.consulta("SELECT id_responsable FROM responsable_asignado WHERE id_asignacion = 1 AND id_mantencion = " + mant);
                        if (l6.Read())
                        {
                            cmb_responsable.SelectedValue = l6.GetInt32(0);
                            if (sql.verificar("SELECT re.nombre FROM responsable_asignado ra INNER JOIN responsable re ON ra.id_responsable = re.id_responsable WHERE ra.id_asignacion = 2 AND ra.id_mantencion = " + mant))
                            {
                                opt_si.PerformClick();
                                SqlDataReader l7 = sql.consulta("SELECT re.nombre FROM responsable_asignado ra INNER JOIN responsable re ON ra.id_responsable = re.id_responsable WHERE ra.id_asignacion = 2 AND ra.id_mantencion = " + mant);
                                while (l7.Read())
                                {
                                    for (int i = 0; i < lst_ayudante.Items.Count; i++)
                                    {
                                        lst_ayudante.SetSelected(i, true);
                                        if (lst_ayudante.SelectedValue.ToString().Equals(l7.GetString(0)))
                                        {
                                            lst_ayudante.SetItemChecked(i, true);
                                        }
                                    }
                                }
                            }
                            
                        }
                        //Quinto: se evalua si hay fechas asignadas
                        SqlDataReader l8 = sql.consulta("SELECT fecha FROM flimite WHERE id_mantencion = " + mant);
                        if (l8.Read())
                        {
                            dtp_flimite.Format = DateTimePickerFormat.Short;
                            dtp_flimite.Value = l8.GetDateTime(0);
                        }
                        SqlDataReader l9 = sql.consulta("SELECT fecha FROM finicio WHERE id_mantencion = " + mant);
                        if (l9.Read())
                        {
                            dtp_finicio.Format = DateTimePickerFormat.Short;
                            dtp_finicio.Value = l9.GetDateTime(0);
                        }
                        SqlDataReader la = sql.consulta("SELECT fecha FROM ftermino WHERE id_mantencion = " + mant);
                        if (la.Read())
                        {
                            dtp_ftermino.Format = DateTimePickerFormat.Short;
                            dtp_ftermino.Value = la.GetDateTime(0);
                        }
                        SqlDataReader lb = sql.consulta("SELECT fecha FROM freal WHERE id_mantencion = " + mant);
                        if (lb.Read())
                        {
                            dtp_freal.Format = DateTimePickerFormat.Short;
                            dtp_freal.Value = lb.GetDateTime(0);
                        }
                        //Sexto: se evalua si hay observaciones
                        SqlDataReader lc = sql.consulta("SELECT id_det_mantencion,fecha,observacion FROM det_mantencion WHERE id_mantencion = " + mant + " ORDER BY fecha");
                        while (lc.Read())
                        {
                            dat_observaciones.Rows.Add(lc.GetInt32(0), lc.GetDateTime(1).ToShortDateString(), lc.GetString(2));
                        }
                    }
                    //Finaliza carga de datos
                    habilitar_solicitud(false);
                }
            }
            catch (Exception ex)
            {
                aux.dialogo("Error al intentar cargar los datos\nInforme a un administrador lo siguiente:\n" + ex.Message, this.Text, 3);
            }
        }

        private void cmb_maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_maquina.SelectedIndex != -1)
            {
                cmd_asignar_articulos.Enabled = true;
            }
            else
            {
                cmd_asignar_articulos.Enabled = false;
            }
        }

        private void txt_solicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 1);

            if (e.KeyChar.Equals('\r') && txt_solicitud.Text.Length > 0)
            {
                buscar(int.Parse(txt_solicitud.Text));
            }
        }

        private void txt_folio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 1);
        }

        private void txt_detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = aux.valida_teclas(e, 3);
        }

        private void dat_observaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (!dat_observaciones.CurrentRow.IsNewRow)
                {
                    if (aux.dialogo("¿Desea eliminar la fila seleccionada?", this.Text, 1) == DialogResult.Yes)
                    {
                        fila = dat_observaciones.CurrentRow.Index;
                        id_detalle = int.Parse(dat_observaciones.CurrentRow.Cells[0].Value.ToString());
                        remover_detalle(fila, id_detalle, 1);
                    }
                }
            }
        }

        private void dat_observaciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell celda_id = dat_observaciones.Rows[e.RowIndex].Cells[0];
                if (celda_id.Value == null)
                {
                    celda_id.Value = 0;
                }
                DataGridViewCell celda_fecha = dat_observaciones.Rows[e.RowIndex].Cells[1];
                if (celda_fecha.Value == null)
                {
                    celda_fecha.Value = DateTime.Today.ToShortDateString();
                }
            }
            catch { }
        }

        private void dat_observaciones_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!dat_observaciones.CurrentRow.IsNewRow)
            {
                dat_observaciones.Rows.Insert(e.RowIndex + 1, 1);
            }
        }

        private void dat_observaciones_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }

        private void dat_observaciones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dat_observaciones.Rows[fila].Cells[2].Value == null)
                {
                    if (dat_observaciones.Rows[fila].IsNewRow)
                    {
                        dat_observaciones.Rows[fila].Cells[0].Value = null;
                        dat_observaciones.Rows[fila].Cells[1].Value = null;
                    }
                }
            }
            catch { }
        }

        private void remover_detalle(int fila, int id_detalle, int op)
        {
            if (sql.verificar("SELECT * FROM det_mantencion WHERE id_det_mantencion = " + id_detalle))
            {
                if (op == 2)
                {
                    if (aux.dialogo("¿Desea eliminar observación?", this.Text, 1) == DialogResult.Yes)
                    {
                        sql.ejecutar("DELETE FROM det_mantencion WHERE id_det_mantencion = " + id_detalle);
                    }
                    else
                    {
                        dat_observaciones.Rows[fila].Cells[2].Value = detalle;
                    }
                }
                else
                {
                    sql.ejecutar("DELETE FROM det_mantencion WHERE id_det_mantencion = " + id_detalle);
                }
            }
            dat_observaciones.Rows.RemoveAt(fila);
        }

        private void dat_observaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (dat_observaciones.Rows[fila].Cells[2].Value == null)
            {
                if (!dat_observaciones.Rows[fila].IsNewRow)
                {
                    id_detalle = int.Parse(dat_observaciones.Rows[fila].Cells[0].Value.ToString());
                    remover_detalle(fila, id_detalle, 2);
                }
            }
        }

        private void dat_observaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (dat_observaciones.Rows[fila].Cells[2].Value == null)
                {
                    if (!dat_observaciones.Rows[fila].IsNewRow)
                    {
                        id_detalle = int.Parse(dat_observaciones.Rows[fila].Cells[0].Value.ToString());
                        remover_detalle(fila, id_detalle, 2);
                    }
                }
            }
            catch { }
        }

        private void cmb_maquina_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    cmb_maquina.SelectedIndex = -1;
                    break;
            }
        }

        private void cmb_responsable_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    cmb_responsable.SelectedIndex = -1;
                    break;
            }
        }

        private void cmb_responsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_responsable.SelectedIndex == -1)
            {
                opt_no.PerformClick();
                opt_si.Enabled = false;
                opt_no.Enabled = false;
            }
            else
            {
                opt_si.Enabled = true;
                opt_no.Enabled = true;
            }
        }

        private void cmb_linea_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    cmb_linea.SelectedIndex = -1;
                    break;
            }
        }

        private void cmb_maquina_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    cmb_maquina.SelectedIndex = -1;
                    break;
            }
        }

        private void cmb_responsable_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    cmb_responsable.SelectedIndex = -1;
                    break;
            }
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            if (mantencion != 0)
            {
                if (aux.dialogo("¿Desea eliminar la actividad?", this.Text, 1) == DialogResult.Yes)
                {
                    if ((sql.ejecutar("UPDATE mantencion SET id_estado_mantencion = 3 WHERE id_mantencion = " + mantencion)) > 0)
                    {
                        sql.ejecutar("EXEC registro_mantencion " + mantencion + ", '" + usuario + "', 3");
                        aux.dialogo("Actividad marcada como eliminada correctamente", this.Text, 2);
                        reinicia_valores();
                    }
                    else
                    {
                        aux.dialogo("No se pudo marcar como eliminada la actividad", this.Text, 3);
                    }
                }
            }
        }

        private void txt_detalle_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            String cadena = "abcdefghijklmnñopqrstuvwxyz";
            cadena += "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            cadena += ",.#-$";
            cadena += "ÁÉÍÓÚáéíóú";
            cadena += "0123456789";
            e.Handled = aux.valida_teclas(cadena, e);
        }

        private void dat_observaciones_Leave(object sender, EventArgs e)
        {
            if (dat_observaciones.CurrentRow.IsNewRow)
            {
                dat_observaciones.CurrentRow.Cells[0].Value = null;
                dat_observaciones.CurrentRow.Cells[1].Value = null;
            }
        }

        private void dtp_freal_FormatChanged(object sender, EventArgs e)
        {
            if (dtp_freal.Format == DateTimePickerFormat.Short)
            {
                opt_finalizado.Checked = true;
            }
            else if (dtp_freal.Format == DateTimePickerFormat.Custom)
            {
                opt_pendiente.Checked = true;
            }
        }
    }
}
