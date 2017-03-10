<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formaulario.aspx.cs" Inherits="VerificacaoDeFormulario.Formaulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Formulário de Login</h2>

    <asp:TextBox ID="txtUsuario" runat="server" placeholder="Digite o usuário." />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="Digite o email corretamente." Display="Dynamic" 
        ControlToValidate="txtUsuario" ForeColor="Red" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
    </asp:RegularExpressionValidator>

    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsuario" runat="server" 
        ErrorMessage="Por favor digite o usuário." ForeColor="Red" 
        ControlToValidate="txtUsuario" Display="Dynamic"></asp:RequiredFieldValidator><br />
    
    <asp:TextBox runat="server" ID="txtSenha" placeholder="Digite a senha."
        TextMode="Password" />
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Por favor digite a senha." ForeColor="Red" 
        ControlToValidate="txtSenha">
    </asp:RequiredFieldValidator><br /><br />
    

    <asp:Button Text="Enviar" ID="cmdEnviar" OnClick="cmdEnviar_Click" runat="server" />

</asp:Content>
