public int guardar(int dni,String apellido,String nombre,String direccion, int telefono, String fecha,String email,String sexo)
        {

            try
            {
                Conexion con = new Conexion();
                con.Conectar();
                con.CrearComando("INSERT INTO DATOS VALUES(?dni,?apellido,?nombre,?direccion,?telefono,?fecha,?email,?sexo)");
                con.AsignarParametro("?dni",MySqlDbType.Int64,dni);
                con.AsignarParametro("?apellido",MySqlDbType.String,apellido);
                con.AsignarParametro("?nombre", MySqlDbType.String, nombre);
                con.AsignarParametro("?direccion",MySqlDbType.String,direccion);
                con.AsignarParametro("?telefono", MySqlDbType.Int64, telefono);
                con.AsignarParametro("?fecha", MySqlDbType.String, fecha);
                con.AsignarParametro("?email", MySqlDbType.String, email);
                con.AsignarParametro("?sexo", MySqlDbType.String, sexo);
                int numReg = 0;
                numReg = con.EjecutarConsulta();
                con.Desconectar();
               return numReg;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Proceso Guardar: " + ex.ToString(), "Error");
                return 0;
            }

        }

public DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                con.Conectar();
                con.CrearComando("SELECT * FROM DATOS");
                
               return con.EjecutarDataTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Proceso Guardar: " + ex.ToString(), "Error");
                return null;
            }
        }


public int eliminar(int dni)
        {
            try
            {
                Conexion con = new Conexion();
                con.Conectar();
                con.CrearComando("DELETE FROM DATOS WHERE DNI = ?dni");
                con.AsignarParametro("?dni", MySqlDbType.Int64, dni);
                int numReg = 0;
                numReg = con.EjecutarConsulta();
                con.Desconectar();
                return numReg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Proceso Guardar: " + ex.ToString(), "Error");
                return 0;
            }
            
        }