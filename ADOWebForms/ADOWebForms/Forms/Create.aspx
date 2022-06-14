<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="ADOWebForms.Forms.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




 

    <div>
        <!-- Control asp Label para mensajes -->
        <hr />
        <div>
            <!-- Par de label html - Control asp por cada propiedad -->
            <label for="idControl">Agregar</label>


            &nbsp;<div>

                <p for="idControl">Create.aspx</p>

            </div>
        </div>

        <div>
            <div>
                <!-- Control asp Button para iniciar acción -->

               

                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
                <asp:TextBox runat="server"></asp:TextBox>

               

            </div>
        </div>


        <div>
            <div>
                <!-- Control asp Button para iniciar acción -->

           



                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

           



            </div>
        </div>


        <div>

            <div>




                <asp:Label ID="Label3" runat="server" Text="Clave"></asp:Label>
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>




            </div>


        </div>




        <div>

            <div>

                                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />

            </div>

        </div>

    </div>






</asp:Content>
