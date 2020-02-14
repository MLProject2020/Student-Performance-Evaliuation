<%@ Page Title="" Language="C#" MasterPageFile="~/GuestForms/MainMasterpage.Master" AutoEventWireup="true" CodeBehind="frmGallery.aspx.cs" Inherits="educationSector.frmGallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="panelGallery" runat="server">
    <div class="article">
      <h2> GALLERY</h2>

     <br />
     <marquee scrolldelay="150" behavior="alternate">
          <img src="../images/education5.png"" width="160" height="100" alt="" /> &nbsp
          <img src="../images/educational1.jpg" width="160" height="100" alt="" /> &nbsp
         <img src="../images/ebsl_section_courses.jpg" width="160" height="100" alt="" /> &nbsp
          </marquee>

        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;<asp:Image ID="Image1" runat="server" Height="150px" 
                        ImageUrl="~/images/ed5.jpg" Width="200px" />

                </td>
                <td>
                    &nbsp;
                    <asp:Image ID="Image2" runat="server" Height="150px" 
                        ImageUrl="~/images/education6.jpg" Width="200px" />
                </td>
                <td>
                    &nbsp;
                    <asp:Image ID="Image3" runat="server" Height="150px" 
                        ImageUrl="~/images/ed1.jpg" Width="200px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
           
        </table>

     <br />
     
     <marquee scrolldelay="150" behavior="alternate">
          <img src="../images/education5.png"" width="160" height="100" alt="" /> &nbsp
          <img src="../images/educational1.jpg" width="160" height="100" alt="" /> &nbsp
         <img src="../images/ebsl_section_courses.jpg" width="160" height="100" alt="" /> &nbsp
          </marquee>
 </div>

   </asp:Panel>
</asp:Content>
