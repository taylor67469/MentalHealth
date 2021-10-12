<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MentalHealth._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron"style="background-color:powderblue; color:white;">
        <h1>Mental Health Facts</h1>
        <p class="lead">This is a webpage to familiarize people with mental health facts.</p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Mental Health Facts</h2>
            <strong><h3 id="randoTitle"></h3></strong>
            <span id="randoText"></span>
            <a href="https://health.gov/myhealthfinder" title="MyHealthfinder">
<img src="https://health.gov/themes/custom/healthfinder/images/MyHF.svg" alt="MyHealthfinder"/>
</a>
                <button id="factBtn">New fact</button>
            <script>
                $(document).ready(function () { 
                    $("#factBtn").on('click',btnClick);
                    function btnClick(event) {
                        $("#randoTitle").text("");
                        $("#randoText").text("");
                        $.get(
                           "https://health.gov/myhealthfinder/api/v3/topicsearch.json?categoryId=20")
                            .then(function (data) {
                                function getRandomInt(max) {
                                    return Math.floor(Math.random() * max);
                                }
                                var mySize1 = data.Result.Resources.Resource.length-1;
                                var mySize2 = data.Result.Resources.Resource[getRandomInt(mySize1)].Sections.section.length-1;
                                var mySize3 = getRandomInt(mySize1);
                                $("#randoText").html(data.Result.Resources.Resource[mySize3].Sections.section[getRandomInt(mySize2)].Content);
                                //$("#randoTitle").append(data.Result.Resources.Resource[getRandomInt(mySize3)].Title);
                            })
                        event.preventDefault();
                    }
                    
                })
                    
                    
  
            </script>

        </div>
    </div>

</asp:Content>
