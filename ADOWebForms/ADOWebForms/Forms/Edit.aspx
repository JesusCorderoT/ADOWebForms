<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ADOWebForms.Forms.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div>
        <!-- Control asp Label para mensajes -->
        <hr />
        <div>
            <!-- Par de label html - Control asp por cada propiedad -->
            <label for="idControl">Actualizar</label>


            &nbsp;<div>

                <p for="idControl">Edit.aspx</p>

                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>



                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>



            </div>
        </div>

        <div>
            <div>
                <!-- Control asp Button para iniciar acción -->

                <asp:Label ID="lblNombres" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

            </div>
        </div>


        <div>
            <div>
                <!-- Control asp Button para iniciar acción -->

                <asp:Label ID="Label5" runat="server" Text="Clave"></asp:Label>
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>



            </div>
        </div>


        <div>

            <div>


                <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />


            </div>


        </div>


    </div>




</asp:Content>
