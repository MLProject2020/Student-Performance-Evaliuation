<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="educationSector.GuestForms.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>result prediction</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href="../css/style.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="../css/coin-slider.css" />
<script type="text/javascript" src="../js/cufon-yui.js"></script>
<script type="text/javascript" src="../js/droid_sans_400-droid_sans_700.font.js"></script>
<script type="text/javascript" src="../js/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="../js/script.js"></script>
<script type="text/javascript" src="../js/coin-slider.min.js"></script>
  <script type="text/javascript">
       
            var image1=new Image()
            image1.src = "../images/Edu_Banner3.JPG"
            var image2=new Image()
            image2.src="../images/Edu_Banner3.JPG"
            var image3=new Image()
            image3.src="../images/education6.JPG"
            var image4=new Image()
            image4.src="../images/Edu_Banner1.JPG"
            var image5=new Image()
            image5.src = "../images/Edu_Banner4.JPG"
            var image6=new Image()
            image6.src = "../images/slide1.JPG"
                  
</script>
</head>
<body>
<div class="main">
  <div class="header">
    <div class="header_resize">
      <div class="menu_nav">
        <ul>
           <ul>
          <li><a href="Index.aspx"><span>HOME</span></a></li>        
          
          <li><a href="frmAboutus.aspx"><strong>ABOUT US</strong></a></li>
          <li><a href="frmLogin.aspx">USER LOGIN</a></li>
        </ul>
        </ul>
      </div>
     <div class="logo">
          <h1><a href="Index.aspx"><span>RESULT PREDICTION</span> <small>Student Future Development Using ML</small></a></h1>
      </div>
      <div class="clr"></div>
     <%-- <div class="slider">
        <div id="coin-slider"> --%><%--<a href="#"><img src="../images/Index1.jpg" alt="" /> </a> 
        <a href="#"><img src="../images/Index5.jpg" alt="" /> </a> 
        <a href="#"><img src="../images/Index6.jpg" alt="" /> </a> </div>--%>

         <div id="Div1">
                <img src="../images/slide1.JPG" width="960px" height="480px" name="slide" />
                <script type="text/javascript">
            <!--
                    var step = 1
                    function slideit() {
                        document.images.slide.src = eval("image" + step + ".src")
                        if (step < 6)
                            step++
                        else
                            step = 1
                        setTimeout("slideit()", 2500)
                    }
                    slideit()
            //-->
                </script>
            </div>
        <div class="clr"></div>
      <%--</div>--%>
      <div class="clr"></div>
    </div>
  </div>
 
 
   <div class="footer">
    <div class="footer_resize">
       <p class="lf">Copyright &copy; <a href="#">Student</a>. All Rights Reserved</p>
      <p class="rf">Student Future <a target="_blank" href="#">Prediction</a></p>
     
    </div>
  </div>
</div>
</body>
</html>
