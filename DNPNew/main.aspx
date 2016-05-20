<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="DNPNew.main" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html>
<head>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/picker_main.css">
    <link rel="stylesheet" type="text/css" href="css/picker.css">

    <script src="https://code.jquery.com/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="js/moment.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <script type="text/javascript" src="js/picker.js"></script>
</head>
<body>




    <form id="form1" runat="server">
        <div class="kanta1">

            <div class="jumbotron">
                <h1 runat="server" id="header" align="center">Welcome to VIA Fitness</h1>
                <p runat="server" id="headerText" align="center">Lets get fit together</p>
            </div>
        </div>

        <div class="kanta2">

            <select runat="server" id="selectTraining" class="form-control">
                <option>Weights training</option>
                <option>Insane training</option>
                <option>Crossfit</option>
                <option>Running</option>
            </select>


            <input runat="server" id="inputDuration" class="form-control input-lg" type="text" placeholder="Duration of workout (minutes)">

            <div class="container">
                <div class="row">
                    <div class='col-sm-6'>
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker'>
                                <input type='text' class="form-control" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add workout" class="btn btn-success" OnClick="Button1_Click" />
        </div>
        <div class="kanta1">
        </div>
    </form>
        <script type="text/javascript">
            $(function () {
                $('#datetimepicker').datetimepicker();
            });
        </script>
</body>
</html>
