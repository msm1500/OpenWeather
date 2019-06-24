<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OpenWeather.Default" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family:Arial;
            font-size: 14px;

        }

        table th
        {
            background-color:#ffffff;
            color:#333;
            font-weight: bold;
        }

        table th, table td
        {
            padding: 5px;
            border: 1px solid #ccc;

        }

           table, table table td
        {
            
            border: 0px solid #ccc;

        }

    </style>



</head>
<body>
    <form id="form1" runat="server">
        Please enter city name: 

        <asp:TextBox ID="txtCity" runat="server" Text=""/>
        <asp:Button Text="Check Weather" runat="server" OnClick="GetWeatherInfo" />
        <hr/>
        <table id="tblWeather" runat="server" border="0" cellpadding="0" cellspacing="0" visible="false">
       
            <th colspan="2">
               -- Weather info --
            </th>
        </tr>

        <tr>
            <td>
                City: 
                <asp:Label ID="lblCity_Country" runat="server"/>.

                <asp:Label ID="lblDescription" runat="server"/>, 
                Humidity: 
                <asp:Label ID="lblHumidity" runat="server"/>
            
            </td>
        </tr>
        <tr>
            <td>
                Temp: 
                Min:
                <asp:Label ID="lblTempMin" runat="server"/>
                Max:
                <asp:Label ID="lblTempMax" runat="server"/>
                Day:
                <asp:Label ID="lblTempDay" runat="server"/>
                Night:
                <asp:Label ID="lblTempNight" runat="server"/>
            
            </td>
        </tr>
               <%--<tr>
            <td>
                Times: 
                Sunrise:
                <asp:Label ID="lblTimeSunrise" runat="server"/>
                Sunset:
                <asp:Label ID="lblTimeSunset" runat="server"/>
                
            
            </td>
        </tr>--%>

        </table>
        


    </form>
</body>
</html>
