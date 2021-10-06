<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MentalHealth._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron"style="background-color:powderblue; color:white;">
        <h1>Mental Health Facts</h1>
        <p class="lead">This is a webpage to familiarize people with mental health facts.</p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Mental Health Facts</h2>
            <p><asp:Panel runat="server" id="randomFact"></asp:Panel></p>
            <a href="https://health.gov/myhealthfinder" title="MyHealthfinder">
<img src="https://health.gov/themes/custom/healthfinder/images/MyHF.svg" alt="MyHealthfinder"/>
</a>
                <asp:Button runat="server" Text="New fact" id="testB"/>
            
        </div>
    </div>

</asp:Content>
