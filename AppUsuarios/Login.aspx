<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppUsuarios.Login" %>

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
    <form id="form1" runat="server" class="form-horizontal">
    <div>
        <nav class="navbar navbar-default">
          <div class="container-fluid">
            <div class="navbar-header">
              <a class="navbar-brand" href="#">
               <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
              </a>
              <a class="navbar-brand">Bienvenidos</a>
              <a class="navbar-brand" href="Registrarse.aspx"><span class="glyphicon glyphicon-user" aria-hidden="true"></span>Registrarse</a>  
            </div>
          </div>
        </nav>
        <!-- Form Name -->
        <div align="center">
            <legend> Iniciar sesion</legend>
        </div>
       
        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtEmail">Email</label>  
            <div class="col-md-4">
             <div class="input-group">
               <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-envelope" aria-hidden="true"></span></span> 
              <input runat="server" id="txtEmail" name="txtEmail" placeholder="Email" class=" form-control input-md" required="" type="text"/>
            </div>
          </div>
        </div>

        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtPass">Password</label>  
          <div class="col-md-4">
              <div class="input-group">
                  <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-lock" aria-hidden="true"></span></span> 
                 <input  runat="server" id="txtPass" name="txtPass" placeholder="Password" class="form-control input-md" required="" type="text"/>
             </div>
          </div>
        </div>
        <!-- Button -->
        <div class="form-group">
          <label class="col-md-6 control-label" for="btnIngresar"></label>
          <div class="col-md-6">
            <asp:Button ID="btnIngresar" runat="server" class="btn btn-success" Text="Ingresar" OnClick="btnIngresar_Click" />
          </div>
        </div>

      </div>
        
    </form>
</body>
</html>
