
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Load_Method.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <input type ="button" id = "btn" value = "Click to Get Data"/>
            <br />

            <div id ="result">

            </div>
        </div>
    </form>
    <script src="Jquery.js"></script>
    <script>

        $(document).ready(function () {

            /*
            Button Click Event:
            When the button is clicked, the load() method fetches content from HtmlPage1.html.
            The loaded content is inserted into the <div id="result">.
            A callback function displays an alert once the content is successfully loaded.
            */
            $("#btn").click(function () {
                /*
                Syntax: 
                $(selector).load(URL , data , callback);
                The required URL parameter specifies the URL you wish to load.
                The optional data parameter specifies a set of querystring key/value pairs
                to send along with the request.
                The optional callback parameter is the name of a function to be executed after
                the load() method is completed.
                */


                /*The load() method loads data from a server and puts the returned data into the selected element.
                  The jQuery load() method is a simple but powerful AJAX method.
                */

                $("#result").load("Pages/HtmlPage1.html" , function() {
                        alert("Load method Done.....");
                    });
                    
                //$("#result").load("Pages/HtmlPage1.html #p2");
                //$("#result").load("Pages/HtmlPage1.html h1 , h2");
            });
        });

        /*
Language: Specifies the programming language used (C# in this case).
AutoEventWireup: Automatically binds events to their handlers.
CodeBehind: Indicates the file that contains the server-side logic.
Inherits: Specifies the class that this page inherits from.
*/
    </script>
</body>
</html>

