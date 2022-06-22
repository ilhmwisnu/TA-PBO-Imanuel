<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PBO_Imanuel._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-3">
        <div runat="server" id="col" class="d-flex flex-column">
            <% for (int i = 0; i < 5; i++)
                { %>
                <div class="rounded p-4 cardd text-white mb-3">
                <div class="row">
                    <div class="col-8">
                        Model :  <span>Avanza</span><br />
                        Jumlah silinder : <span>4</span><br />
                        Harga : <span>Mulai Rp 277 Juta</span><br />
                        Dimensi : <span>4.030 mm P x 1.710 mm L x 1.635 mm T</span><br />
                        Sistem penggerak roda : <span>Penggerak roda depan</span><br />
                        Kapasitas tangki BBM : <span>36 L</span><br />
                        Mesin : <span>1L 3-silinder</span><br />
                        Daya kuda : <span>98 HP</span><br />
                    </div>
                    <div class="col-4">
                        <div class="row">
                            <img
                                width="300"
                                src="https://cdn.motor1.com/images/mgl/1Zze8w/s3/mercedes-amg-safety-car-und-medical-car-formel-1-2022.jpg"
                                alt=""
                                class="rounded mx-auto" />
                            <div class="col text-center mt-3">
                                <a href="~/Ubah" runat="server" class="btn btn-primary">
                                    <svg
                                        xmlns="http://www.w3.org/2000/svg"
                                        width="16"
                                        height="16"
                                        fill="currentColor"
                                        class="bi bi-pen-fill"
                                        viewBox="0 0 16 16">
                                        <path
                                            d="m13.498.795.149-.149a1.207 1.207 0 1 1 1.707 1.708l-.149.148a1.5 1.5 0 0 1-.059 2.059L4.854 14.854a.5.5 0 0 1-.233.131l-4 1a.5.5 0 0 1-.606-.606l1-4a.5.5 0 0 1 .131-.232l9.642-9.642a.5.5 0 0 0-.642.056L6.854 4.854a.5.5 0 1 1-.708-.708L9.44.854A1.5 1.5 0 0 1 11.5.796a1.5 1.5 0 0 1 1.998-.001z" />
                                    </svg>
                                </a>
                                <button class="btn btn-danger">
                                    <svg
                                        xmlns="http://www.w3.org/2000/svg"
                                        width="16"
                                        height="16"
                                        fill="currentColor"
                                        class="bi bi-trash-fill"
                                        viewBox="0 0 16 16">
                                        <path
                                            d="M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z" />
                                    </svg>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <% } %>
        </div>
    </div>

</asp:Content>
