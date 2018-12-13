<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teste.aspx.cs" Inherits="Smartrooms.teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <!-- Required meta tags -->
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"/>

    <title>Smart Study Rooms</title>
</head>
<body style="background: rgb(243, 243, 243)">
    <form id="form1" runat="server">
        <div id="app">

        <header>
            <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
                <a class="navbar-brand" href="https://smartrooms.azurewebsites.net/" style="font-weight: bold;">Distributed Systems 18/19</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarCollapse">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="#">Grupo 1</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Grupo 2</a>
                        </li>
                        <li class="nav-item active">
                            <a class="nav-link" href="#">Grupo 3</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Grupo 4</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Grupo 5</a>
                        </li>
                    </ul>
                    <ul class="nav navbar-nav ml-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="#">Subscribe</a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>

        <div class="container" style="margin-top: 80px" v-show="view == 'charts'">
            <h3>subscribe</h3>
            <p>if you like to receive an email notification with rooms occupation hourly fill the fields below: </p>
            <br/>
            <br/>
            <form onsubmit="insert()">
                <div class="form-group options">
                    <label class="control-label col-md-1" for="optiontext">email:</label>
                    <input type="email" id="emailField" required placeholder="Enter your email">
                    <br/>
                    <label class="control-label col-md-4" for="optiontext">Choose a room</label>
                    <div class="col-md-6">
                        <input type="checkbox" name="option[]" value="option0" /> room 0<br>
                        <input type="checkbox" name="option[]" value="option1" /> room 1<br>
                        <input type="checkbox" name="option[]" value="option2" /> room 2<br>
                        <input type="checkbox" name="option[]" value="option3" /> room 3<br>
                    </div>
                </div>

                <input type="submit">


            </form>

        </div>

    </div>
    </form>
</body>
</html>
