<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>你对李政民的印象</title>
</head>
<body>
    <form id="form1" runat="server">
        <label>Name:
            <input type="text" name="text1" value="李政民"/><br />
        </label>
        <label>StudentNumber:
            <input type="text" name="text1" value="2018302110388"/><br />
        </label>
        <img src="img/pic.jpg" alt="李政民照片" width="600" height="400"/><br />

        <textarea name="info" rows="7" cols="70">
        Please enter a list of all your top 5 impressions on me:
        1.
        2.
        3.
        4.
        5.</textarea><br /><br />
        <button name="senddata" type="submit">Submit</button>
    </form>
</body>
</html>
