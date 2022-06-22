<%@ Page Title="Tambah" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tambah.aspx.cs" Inherits="PBO_Imanuel.Tambah" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row cardd rounded p-4 ">
            <div class="col-4 mb-3">
                <asp:Label Text="Model" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="model" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Jumlah silinder" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="silinder" TextMode="Number" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Harga (Juta)" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="harga" TextMode="Number" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Dimensi" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="dimensi" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Sistem penggerak roda" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="sistem" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Kapasitas tangki (L)" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="kapasitas" TextMode="Number" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Mesin" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="mesin" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Daya kuda (HP)" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="daya" TextMode="Number" class="form-control border-0  full-width" runat="server" />
            </div>
            <div class="col-4 mb-3">
                <asp:Label Text="Url Gambar" runat="server" />
            </div>
            <div class="col-8 mb-3">
                <asp:TextBox ID="imageUrl" class="form-control border-0  full-width" runat="server" />
            </div>

            <div class="col-4 mb-3">
                <asp:Label ID="result" Text="" style="color : red" runat="server" />

            </div>
            <div class="col-8 mb-3">
                <a href="~/" class="btn table-bg text-white" runat="server">Batal</a>
                <asp:Button class="btn table-bg text-white" Text="Tambahkan" OnClick="insertData" runat="server" />

            </div>

        </div>
    </div>



</asp:Content>
