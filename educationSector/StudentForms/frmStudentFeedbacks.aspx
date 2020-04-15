<%@ Page Title="" Language="C#" MasterPageFile="~/StudentForms/StudentMasterpage.Master" AutoEventWireup="true" CodeBehind="frmStudentFeedbacks.aspx.cs" Inherits="educationSector.StudentForms.frmStudentFeedbacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 171px;
        }
        .style2
        {
            width: 198px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
                <asp:Panel ID="Panel7" runat="server">
                    <div class="article">
      <h2><span>POST</span> FEEDBACKS</h2>
                    <table align="center" style="width: 79%;">
                        <tr>
                            <td class="style1">
                                &nbsp;</td>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="text-align: center; " class="style1">
                                <asp:ImageButton ID="ImageButton1" runat="server" 
                                    ImageUrl="~/images/folder-down-icon.jpg" onclick="ImageButton1_Click" />
                            </td>
                            <td style="text-align: center; " class="style2">
                                <asp:ImageButton ID="ImageButton2" runat="server" 
                                    ImageUrl="~/images/folder-edit-icon.jpg" onclick="ImageButton2_Click" />
                            </td>
                            <td style="text-align: center">
                                <asp:ImageButton ID="ImageButton3" runat="server" 
                                    ImageUrl="~/images/folder-process-icon.jpg" onclick="ImageButton3_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; font-size: small; " class="style1">
                                <b>Pending</b></td>
                            <td style="text-align: center; font-size: small; " class="style2">
                                <b>Post New Question</b></td>
                            <td style="text-align: center; font-size: small;">
                                <b>Answered</b></td>
                        </tr>
                    </table>
                    <br />
                    
                    <asp:Panel ID="Panel8" runat="server" HorizontalAlign="Center">
                        <br />
                        <asp:Table ID="Table1" runat="server" Font-Size="Small" 
                            HorizontalAlign="Center">
                        </asp:Table>
                        <br />
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel9" runat="server" Visible="False">
                        <br />
                        <table align="center">
                            <tr>
                                <td align="center" 
                                    style="width: 387px; background-image: url('images/Post_Question.JPG'); height: 207px;" 
                                    valign="middle">
                                    <br />
                                    <table align="center" style="width:88%; text-align: center;">
                                        <tr>
                                            <td style="text-align: left; font-size: small; width: 86px;">
                                                <b>Question</b></td>
                                            <td style="text-align: left">
                                                <asp:TextBox ID="txt_postQuestion" runat="server" Height="80px" 
                                                    TextMode="MultiLine" Width="250px" Font-Size="Small"></asp:TextBox>
                                            </td>
                                            <td style="text-align: left">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                    ControlToValidate="txt_postQuestion" ErrorMessage="*" Font-Size="Small" 
                                                    ToolTip="filed required" ValidationGroup="postquestions"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left; width: 86px;">
                                                &nbsp;</td>
                                            <td style="text-align: left">
                                                &nbsp;</td>
                                            <td style="text-align: left">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left; width: 86px;">
                                                &nbsp;</td>
                                            <td align="right">
                                                <asp:Button ID="btn_postquestion" runat="server" Font-Size="Small" 
                                                    onclick="btn_postquestion_Click" Text="Submit" 
                                                    ValidationGroup="postquestions" />
                                            </td>
                                            <td style="text-align: left">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                    <br />
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <br />
                        
                    </asp:Panel>
                    </div>
                </asp:Panel>
                

</asp:Content>
