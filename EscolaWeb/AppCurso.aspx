<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppCurso.aspx.cs" Inherits="EscolaWeb.Curso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Curso
            <asp:TextBox runat="server" ID="CursoNome" MaxLength="32"></asp:TextBox>
        </div>
        <div>   
            <asp:CheckBox runat ="server" ID="chkStatusCurso" Text="curso ativo" />
        </div>
        <div>   
            <asp:DataGrid runat ="server" ID ="grdCursos"> </asp:DataGrid>
        </div>
        <div>
            <asp:Button runat="server" ID="btnCursoGrava" Text="grava curso" />
            <asp:Button runat="server" ID="btncursoNovo" Text="novo curso" />
        </div>
    </form>
</body>
</html>
