<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="BulkPrediction.aspx.cs" Inherits="educationSector.AdminForms.BulkPrediction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="panelAboutus" runat="server">
  <div class="article">
   <h2>RESULT PREDICTION MODULE!!!</h2>


   	 <br />
     <TABLE ID="Table5" align="left" border="0" cellPadding="1" cellSpacing="1" 
         style="BORDER-TOP: #006699 1px solid;BORDER-LEFT: #006699 1px solid;BORDER-BOTTOM: #006699 1px solid;BORDER-RIGHT: #006699 1px solid;WIDTH: 600px;FONT-SIZE: 12px; COLOR: #000000; FONT-FAMILY: Verdana">
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="Label1" runat="server" Width="93px">Select course</asp:Label>
             </td>
             <td>
                 <asp:DropDownList ID="DropDownList_Course" runat="server" AutoPostBack="True" 
                     CssClass="txtBox" 
                     onselectedindexchanged="DropDownList_Course_SelectedIndexChanged" Width="96px">
                 </asp:DropDownList>
             </td>
             <td>
                 <asp:Label ID="Label2" runat="server">Sem</asp:Label>
             </td>
             <td>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ControlToValidate="DropDownList_Sem" ErrorMessage="*" ValidationGroup="A" 
                     ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
             <td>
                 <asp:DropDownList ID="DropDownList_Sem" runat="server" CssClass="txtBox">
                 </asp:DropDownList>
             </td>
             <td>
                 <asp:Button ID="ButtonView" runat="server" CssClass="Button_Click" 
                     onclick="ButtonView_Click" Text="Get Testing Dataset" ValidationGroup="A" 
                     Height="50px" Width="200px" />
             </td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
     </TABLE>
     <br />
     <br />
     <br />
                 <br />
      <br />
                 <br />
      <asp:Label ID="lblMsg" runat="server"></asp:Label>
                 <br />                                <asp:Table ID="tableTraining" runat="server">
                                                </asp:Table>
                                            
                      


               </div>            
<asp:Panel ID="panelImport" runat="server" Visible="False">

		 <div class="article">
			 <h2>PREDICTION </h2>
    		   
            <table style="width: 100%;">
                <tr>
                    <td>
                        &nbsp;<span><asp:Button ID="btnResult" runat="server" Height="40px" 
                            onclick="btnResult_Click" Text="RESULT PREDICTION" Width="300px" />
                        </span>
                    </td>
                    <td>
                        &nbsp;
                        </td>
                    <td>
                        &nbsp;&nbsp;<span><asp:Button ID="btnView" runat="server" Height="40px" 
                            onclick="btnView_Click" Text="View Training Dataset" Visible="False" 
                            Width="150px" />
                        </span></td>
                </tr>
            </table>						 
						   <div>
						   		&nbsp;&nbsp; &nbsp;&nbsp;
						  </div>
                          <asp:Panel ID="Panel1" runat="server" Visible="False">
                              <br />
                             <h2>View Students Dataset!</h2>
                              <asp:Label ID="lblDataset" runat="server"></asp:Label>
                              <br />
                              <br />
                               <asp:Table ID="tableDataset" runat="server">
                              </asp:Table>
                               <br />
            </asp:Panel>
            
              <asp:Panel ID="Panel2" runat="server" Visible="False">
       <h2>STUDENTS RESULT PREDICTION!</h2>
      </asp:Panel>



             <asp:Table ID="tablePrediction" runat="server">
             </asp:Table>
             

                  
   </div>
 
   </asp:Panel>






     
        <asp:Panel ID="Panel5" runat="server" Visible="False">
         <div class="article">
            <h2>
                RESULT ANALYSIS!
            </h2>

            <asp:Table ID="tableResults" runat="server">
                </asp:Table>

                </div>
        </asp:Panel>
       

   </asp:Panel>


</asp:Content>
