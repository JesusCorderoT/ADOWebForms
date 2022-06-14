<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ADOWebForms.Forms.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
<div>
	<!-- Control asp Label para mensajes -->		
    <hr />
    <div>
		<!-- Par de label html - Control asp por cada propiedad -->
        <label for="idControl">Detalles</label>

  
&nbsp;<div>
            
                <p for="idControl">Details.aspx</p>
            
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            
          
            
        </div>
    </div>

    <div>
        <div>
            <!-- Control asp Button para iniciar acción -->
          
            <asp:Label ID="lblNombres" runat="server" Text="Nombre"></asp:Label>
            <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
          
        </div>
    </div>
    

        <div>
        <div>
            <!-- Control asp Button para iniciar acción -->
 
            <asp:Label ID="Label5" runat="server" Text="Clave"></asp:Label>
            <asp:Label ID="lblClave" runat="server" Text=""></asp:Label>
 
        </div>
    </div>
</div>
 
 


</asp:Content>
