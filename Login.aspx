<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CRUDprueba.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/bootstrap-5.3.3-dist/CSS/bootstrap.min.css" rel="stylesheet" />
<script src="~/Content/bootstrap-5.3.3-dist/JS/bootstrap.bundle.min.js"></script>
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <form id="formulario" method="post">

    <div class="col-md-6">
        <div class="form-group">
            <label for="cui">CUI:</label>
            <input type="number" class="form-control" id="cui" name="cui" required>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <label for="nombre">Nombre:</label>
                <input type="text" class="form-control" id="nombre" name="nombre">
            </div>
        </div>


        <div class="col-md-6">
            <div class="form-group">
                <label for="apellido">Apellido:</label>
                <input type="text" class="form-control" id="apellido" name="apellido">
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label for="mail">Correo electrónico:</label>
                <input type="email" class="form-control" id="mail" name="mail">
            </div>
        </div>
    
   
        <div class="col-md-6">
            <div class="form-group">
                <label for="telefono">Teléfono:</label>
                <input type="tel" class="form-control" id="telefono" name="telefono">
            </div>
        </div>
        <div class="col-md-6">
            <div class="form-group">
                <label for="estado">Estado:</label>
                <select class="form-control" id="estado" name="estado">
                    <option value="1">Activo</option>
                    <option value="0">Inactivo</option>
                </select>
            </div>
        </div>


        <div class="col-md-6">
            <div class="form-group">
                <label for="fechaRegistro">Fecha de registro:</label>
                <input type="date" class="form-control" id="fechaRegistro" name="fechaRegistro">
            </div>
        </div>
     
        <div class="col-md-6" style="margin-top: 20px; margin-bottom: 20px">
            <button type="submit" class="btn btn-primary" onclick="insertarPersona()">Insertar</button>
        </div>
    </div>
</form>


<div class="table-responsive">
    <table class="table align-middle table-striped table-hover" id="myTable">
        <thead>
            <tr>
                <td>CUI</td>
                <td>Nombre</td>
                <td>Apellido</td>
                <td>Correo</td>
                <td>Telefono</td>
                <td>Estado</td>
                <td>fecha</td>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>
    <script src="~/Content/bootstrap-5.3.3-dist/js/bootstrap.bundle.min.js"></script>
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha1/dist/js/bootstrap.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</body>
</html>
