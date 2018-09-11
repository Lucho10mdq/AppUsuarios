<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="AppUsuarios.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous"/>

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
    <div>
        <nav class="navbar navbar-default">
          <div class="container-fluid">
            <div class="navbar-header">
              <a class="navbar-brand" href="Login.aspx">
               <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
              </a>
              <a class="navbar-brand">Bienvenidos</a> 
            </div>
          </div>
        </nav>
        <!-- Form Name -->
         <legend><span class="glyphicon glyphicon-user" aria-hidden="true"></span> Formulario de Registracion de Usuario</legend>

        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtNombre">Nombre</label>  
          <div class="col-md-4">
          <input runat="server" id="txtNombre" name="txtNombre" placeholder="Nombre" class="form-control input-md" required="" type="text"/>
          </div>
        </div>
        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtEmail">Email</label>  
          <div class="col-md-4">
          <input runat="server" id="txtEmail" name="txtEmail" placeholder="Email" class="form-control input-md" required="" type="text"/>
          </div>
        </div>
         <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtPassword">Password</label>  
          <div class="col-md-4">
          <input  runat="server" id="txtPassword" name="txtPassword" placeholder="Password" class="form-control input-md" required="" type="text"/>
          </div>
        </div>
        <!-- Button -->
        <div class="form-group">
          <label class="col-md-4 control-label" for="btnGuardar"></label>
          <div class="col-md-4">
           <asp:Button ID="btnGuardar" runat="server" class="btn btn-danger" Text="Guardar" OnClick="btnGuardar_Click"/>
          </div>
        </div>
       </div> 
    </form>
</body>
</html>
