<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyStudent.aspx.cs" Inherits="AppUsuarios.ModifyStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />
        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous"/>
        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <nav class="navbar navbar-default">
              <div class="container-fluid">
                <div class="navbar-header">
                  <a class="navbar-brand" href="Welcome.aspx">
                   <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
                  </a>
                  <a class="navbar-brand">Bienvenidos</a>
                  <a class="navbar-brand" href="AgreeStudent.aspx"><span class="glyphicon glyphicon-user" aria-hidden="true"></span>Agregar Alumno</a>
                    <a class="navbar-brand" href="ListStudent.aspx"><span class="glyphicon glyphicon-th-list" aria-hidden="true"></span>Listado de Alumnos</a>
                    <a class="navbar-brand" href="ModifyStudent.aspx"><span class="glyphicon glyphicon-th-list" aria-hidden="true"></span>Modificar Alumno</a> 
                   <a class="navbar-brand" href="Login.aspx"><span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>Salir</a>  
                </div>
              </div>
          </nav>
       
        <!-- Text input-->
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-xs-12">
                  <legend>Buscar Alumno</legend> 
                  <input  runat="server" id="txtDni" name="txtDni" placeholder="Dni" class="form-control" required="" type="text">
                <!-- Button -->
                    <br />
                  <label class="control-label" for="btnBuscar"></label>
                    <asp:Button ID="btnBuscarDni" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarDni_Click"/>
                  </div>
                <div class="col-md-6 col-xs-12">
                      <legend>Modificar Alumno</legend> 
                      <input  runat="server" id="txtName" name="txtName" placeholder="Nombre" class="form-control"  type="text">
                      <input runat="server" id="txtSurname" name="txtSurname" placeholder="Apellido" class="form-control"  type="text">
                      <input runat="server" id="txtDom" name="txtDom" placeholder="Domicilio" class="form-control"  type="text">
                      <input runat="server" id="txtEmails" name="txtEmails" placeholder="Email" class="form-control"  type="text">
                        <br />
                      <asp:Button ID="btnModificar" runat="server" Text="Guardar" class="btn btn-primary" />
                </div>
               
            </div>
        </div>
    </div>
    </form>
</body>
</html>
