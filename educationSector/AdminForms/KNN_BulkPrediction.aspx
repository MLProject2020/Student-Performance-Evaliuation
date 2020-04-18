<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="KNN_BulkPrediction.aspx.cs" Inherits="educationSector.AdminForms.KNN_BulkPrediction" %>
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
			 <h2>PREDICTION (KNN)</h2>
    		   
            <table style="width: 100%;">
                <tr>
                    <td>
                        &nbsp;<span><asp:Button ID="btnResult" runat="server" Height="40px" 
                            onclick="btnResult_Click" Text="RESULT PREDICTION (KNN)" Width="300px" />
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
             

                  
             <br />
             <asp:Label ID="lblFactor" runat="server"></asp:Label>
             

                  
   </div>
 
   </asp:Panel>






     
        <asp:Panel ID="Panel5" runat="server" Visible="False">
         <div class="article">
            <h2>
                RESULT ANALYSIS (KNN)!
            </h2>

            <asp:Table ID="tableResults" runat="server">
                </asp:Table>

                <br />
             <span>
             <asp:Button ID="btnCompare" runat="server" Height="40px" 
                 onclick="btnCompare_Click" Text="COMPARE ALGORITHMS" Width="300px" />
             </span>

                </div>
        </asp:Panel>
       


    <asp:Panel ID="PanelParameters" runat="server" Visible="False">
    <TABLE id="Table2" style="BORDER-RIGHT: dimgray 1px solid; BORDER-TOP: dimgray 1px solid; BORDER-LEFT: dimgray 1px solid; WIDTH: 500px; BORDER-BOTTOM: dimgray 1px solid; HEIGHT: 350px; BACKGROUND-COLOR: white"
							cellSpacing="1" cellPadding="1" width="418" bgColor="#0" border="0">
							<TR>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699"
									align="center" class="style3">
                                    <asp:Label ID="Label3" runat="server" BackColor="Transparent" Width="168px">&nbsp;&nbsp;&nbsp;&nbsp; 
                                   </asp:Label>
                                </TD>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 109px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 17px; BACKGROUND-COLOR: #006699"
									align="left"><strong class=" ">
                                        <asp:Label ID="Label4" runat="server" Width="150px">Student Parameters</asp:Label>
                                    </strong></TD>
							</TR>
							<TR>
								<TD vAlign="top" align="center" class="style3">
									<TABLE id="Table4" style="WIDTH: 105px; HEIGHT: 350px" cellSpacing="0" 
                                        cellPadding="0" border="0">
										<TR>
											<TD style="HEIGHT: 260px" align="center" bgcolor="beige" valign="top">
												<p>
                                                    <asp:Image ID="Image2" runat="server" Height="350px" 
                                                        ImageUrl="~/images/education5.png" Width="200px" />
                                                </p>
                                            </TD>
										</TR>
									</TABLE>
								</TD>
								<TD vAlign="top" align="left">
									<TABLE id="Table3" style="FONT-SIZE: 12px; COLOR: black; FONT-FAMILY: Verdana" cellSpacing="2"
										cellPadding="3" border="0">
										<TR>
											<TD class="style5">Hrs</TD>
											<TD class="style4" align="left">
                                                <asp:DropDownList ID="DropDownListHrs" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>&gt;4</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>1</asp:ListItem>
                                                </asp:DropDownList>
                                            </TD>
											<TD>
												&nbsp;</TD>
										</TR>
									    <tr>
                                            <td class="style5">
                                                Regular</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListRegular" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Regular</asp:ListItem>
                                                    <asp:ListItem>Irregular</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                Interaction</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListInteraction" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                Time Management</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListTimeMgt" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                Grasping Ability</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListGraspingAbility" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                EXActivities</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListExActivities" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Best</asp:ListItem>
                                                      <asp:ListItem>Better</asp:ListItem>
                                                       <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>                                                                                                    
                                                    
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                PrevSemResults</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListPrevResults" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem Value="89%-100%">S</asp:ListItem>
                                                    <asp:ListItem Value="74%-89%">A</asp:ListItem>
                                                    <asp:ListItem Value="59%-74%">B</asp:ListItem>
                                                    <asp:ListItem Value="49%-59%">C</asp:ListItem>
                                                    <asp:ListItem Value="44%-49%">D</asp:ListItem>
                                                    <asp:ListItem Value="40%-44%">E</asp:ListItem>
                                                    <asp:ListItem Value="&lt;40%">F</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                SSLC</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListSSLC" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem Value="85%-100%">Distinction</asp:ListItem>
                                                    <asp:ListItem Value="60%-85%">FirstClass</asp:ListItem>
                                                    <asp:ListItem Value="45%-60%">SecondClass</asp:ListItem>
                                                    <asp:ListItem Value="35%-45%">ThirdClass</asp:ListItem>
                                                    <asp:ListItem Value="&lt;35%">Fail</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                PUC</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListPUC" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                     <asp:ListItem Value="85%-100%">Distinction</asp:ListItem>
                                                    <asp:ListItem Value="60%-85%">FirstClass</asp:ListItem>
                                                    <asp:ListItem Value="45%-60%">SecondClass</asp:ListItem>
                                                    <asp:ListItem Value="35%-45%">ThirdClass</asp:ListItem>
                                                    <asp:ListItem Value="&lt;35%">Fail</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style7">
                                                IHS</td>
                                            <td align="left" class="style8">
                                                <asp:DropDownList ID="DropDownListIHS" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                     <asp:ListItem>Yes</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="style9">
                                                &nbsp;</td>
                                        </tr>
									</TABLE>
								</TD>
							</TR>
						</TABLE>


    </asp:Panel>


   </asp:Panel>

</asp:Content>
