<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmAddStudents.aspx.cs" Inherits="educationSector.frmAddStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .style1
        {
            width: 155px;
        }
        .style2
        {
            height: 63px;
        }
        .style3
        {
            width: 155px;
            height: 63px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="panelStudentRegister" runat="server">
  <div class="article">
      <h2><span>REGISTER</span> STUDENTS</h2>


 
   <TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" 
        style="width: 750px">
				<TR>
					<TD style="BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE: none"
						vAlign="middle">
						<TABLE id="Table9" style="border-width: 1px; border-color: #006699; FONT-WEIGHT: normal; FONT-SIZE: 12px; WIDTH: 650px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: 309px; "
							cellSpacing="0" cellPadding="0" border="0">
							<TR>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-LEFT: #006699 1px solid;FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 170px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699"
									vAlign="middle" align="left" colSpan="2">
									<asp:Label id="Label5" runat="server">Student Details:</asp:Label></TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; WIDTH: 170px; BORDER-BOTTOM: #006699 1px solid"
									vAlign="middle" align="center">
                                    <asp:Image ID="Image1" runat="server" Height="400px" 
                                        ImageUrl="~/images/education5.png" Width="250px" />
                                </TD>
								<TD vAlign="middle" colSpan="1" rowSpan="2" 
                                    
                                    style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 1px solid; border-color: #006699;">
									<br />
									<TABLE id="Table5" style="BORDER-TOP: 2px double #006699; WIDTH: 360px; BORDER-BOTTOM: 2px groove #006699; HEIGHT: 175px; "
										cellSpacing="3" cellPadding="1" border="0" align="center">
										<TR>
											<TD colspan="3">
												<strong>Basic Information</strong></TD>
										</TR>
										<tr>
                                            <td>
                                                &nbsp;</td>
                                            <td class="style1">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Register No</td>
                                            <td class="style1">
                                                <asp:TextBox ID="TextBox_Reg" runat="server" CssClass="txtBox"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                    ControlToValidate="TextBox_Reg" ErrorMessage="*" ForeColor="Red" 
                                                    ValidationGroup="a"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
										<TR>
											<TD>
												Student Name</TD>
											<TD class="style1">
												<asp:textbox id="TextBox_Name" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" 
                                                    ErrorMessage="*" ControlToValidate="TextBox_Name" ForeColor="Red" 
                                                    ValidationGroup="a"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD>
												&nbsp;</TD>
											<TD class="style1">
                                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                                     ControlToValidate="TextBox_Name" ErrorMessage="Only Alphabets" ForeColor="Red" 
                                                     ToolTip="Only Alphabets" ValidationExpression="^[a-zA-Z ]*$" 
                                                     ValidationGroup="a"></asp:RegularExpressionValidator>
                                            </TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<tr>
                                            <td>
                                                DOB</td>
                                            <td class="style1">
                                                <asp:DropDownList ID="dropdownlistDay" runat="server" Width="40px">
                                                    <asp:ListItem>1</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>5</asp:ListItem>
                                                    <asp:ListItem>6</asp:ListItem>
                                                    <asp:ListItem>7</asp:ListItem>
                                                    <asp:ListItem>8</asp:ListItem>
                                                    <asp:ListItem>9</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                    <asp:ListItem>13</asp:ListItem>
                                                    <asp:ListItem>14</asp:ListItem>
                                                    <asp:ListItem>15</asp:ListItem>
                                                    <asp:ListItem>16</asp:ListItem>
                                                    <asp:ListItem>17</asp:ListItem>
                                                    <asp:ListItem>18</asp:ListItem>
                                                    <asp:ListItem>19</asp:ListItem>
                                                    <asp:ListItem>20</asp:ListItem>
                                                    <asp:ListItem>21</asp:ListItem>
                                                    <asp:ListItem>22</asp:ListItem>
                                                    <asp:ListItem>23</asp:ListItem>
                                                    <asp:ListItem>24</asp:ListItem>
                                                    <asp:ListItem>25</asp:ListItem>
                                                    <asp:ListItem>26</asp:ListItem>
                                                    <asp:ListItem>27</asp:ListItem>
                                                    <asp:ListItem>28</asp:ListItem>
                                                    <asp:ListItem>29</asp:ListItem>
                                                    <asp:ListItem>30</asp:ListItem>
                                                    <asp:ListItem>31</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="dropdownlistMonth" runat="server" Width="40px">
                                                    <asp:ListItem>1</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>5</asp:ListItem>
                                                    <asp:ListItem>6</asp:ListItem>
                                                    <asp:ListItem>7</asp:ListItem>
                                                    <asp:ListItem>8</asp:ListItem>
                                                    <asp:ListItem>9</asp:ListItem>
                                                    <asp:ListItem>10</asp:ListItem>
                                                    <asp:ListItem>11</asp:ListItem>
                                                    <asp:ListItem>12</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="dropdownlistYear" runat="server" Width="70px">
                                                    <asp:ListItem Value="1901">1901</asp:ListItem>
                                                    <asp:ListItem>1902</asp:ListItem>
                                                    <asp:ListItem>1903</asp:ListItem>
                                                    <asp:ListItem>1904</asp:ListItem>
                                                    <asp:ListItem>1905</asp:ListItem>
                                                    <asp:ListItem>1906</asp:ListItem>
                                                    <asp:ListItem>1907</asp:ListItem>
                                                    <asp:ListItem>1908</asp:ListItem>
                                                    <asp:ListItem>1909</asp:ListItem>
                                                    <asp:ListItem>1910</asp:ListItem>
                                                    <asp:ListItem>1911</asp:ListItem>
                                                    <asp:ListItem>1912</asp:ListItem>
                                                    <asp:ListItem>1913</asp:ListItem>
                                                    <asp:ListItem>1914</asp:ListItem>
                                                    <asp:ListItem>1915</asp:ListItem>
                                                    <asp:ListItem>1916</asp:ListItem>
                                                    <asp:ListItem>1917</asp:ListItem>
                                                    <asp:ListItem>1918</asp:ListItem>
                                                    <asp:ListItem>1919</asp:ListItem>
                                                    <asp:ListItem>1920</asp:ListItem>
                                                    <asp:ListItem>1921</asp:ListItem>
                                                    <asp:ListItem>1922</asp:ListItem>
                                                    <asp:ListItem>1923</asp:ListItem>
                                                    <asp:ListItem>1924</asp:ListItem>
                                                    <asp:ListItem>1925</asp:ListItem>
                                                    <asp:ListItem>1926</asp:ListItem>
                                                    <asp:ListItem>1927</asp:ListItem>
                                                    <asp:ListItem>1928</asp:ListItem>
                                                    <asp:ListItem>1929</asp:ListItem>
                                                    <asp:ListItem>1930</asp:ListItem>
                                                    <asp:ListItem>1931</asp:ListItem>
                                                    <asp:ListItem>1932</asp:ListItem>
                                                    <asp:ListItem>1933</asp:ListItem>
                                                    <asp:ListItem>1934</asp:ListItem>
                                                    <asp:ListItem>1935</asp:ListItem>
                                                    <asp:ListItem>1936</asp:ListItem>
                                                    <asp:ListItem>1937</asp:ListItem>
                                                    <asp:ListItem>1938</asp:ListItem>
                                                    <asp:ListItem>1939</asp:ListItem>
                                                    <asp:ListItem>1940</asp:ListItem>
                                                    <asp:ListItem>1941</asp:ListItem>
                                                    <asp:ListItem>1942</asp:ListItem>
                                                    <asp:ListItem>1943</asp:ListItem>
                                                    <asp:ListItem>1944</asp:ListItem>
                                                    <asp:ListItem>1945</asp:ListItem>
                                                    <asp:ListItem>1946</asp:ListItem>
                                                    <asp:ListItem>1947</asp:ListItem>
                                                    <asp:ListItem>1948</asp:ListItem>
                                                    <asp:ListItem>1949</asp:ListItem>
                                                    <asp:ListItem>1950</asp:ListItem>
                                                    <asp:ListItem>1951</asp:ListItem>
                                                    <asp:ListItem>1952</asp:ListItem>
                                                    <asp:ListItem>1953</asp:ListItem>
                                                    <asp:ListItem>1954</asp:ListItem>
                                                    <asp:ListItem>1955</asp:ListItem>
                                                    <asp:ListItem>1956</asp:ListItem>
                                                    <asp:ListItem>1957</asp:ListItem>
                                                    <asp:ListItem>1958</asp:ListItem>
                                                    <asp:ListItem>1959</asp:ListItem>
                                                    <asp:ListItem>1960</asp:ListItem>
                                                    <asp:ListItem>1961</asp:ListItem>
                                                    <asp:ListItem>1962</asp:ListItem>
                                                    <asp:ListItem>1963</asp:ListItem>
                                                    <asp:ListItem>1964</asp:ListItem>
                                                    <asp:ListItem>1965</asp:ListItem>
                                                    <asp:ListItem>1966</asp:ListItem>
                                                    <asp:ListItem>1967</asp:ListItem>
                                                    <asp:ListItem>1968</asp:ListItem>
                                                    <asp:ListItem>1969</asp:ListItem>
                                                    <asp:ListItem>1970</asp:ListItem>
                                                    <asp:ListItem>1971</asp:ListItem>
                                                    <asp:ListItem>1972</asp:ListItem>
                                                    <asp:ListItem>1973</asp:ListItem>
                                                    <asp:ListItem>1974</asp:ListItem>
                                                    <asp:ListItem>1975</asp:ListItem>
                                                    <asp:ListItem>1976</asp:ListItem>
                                                    <asp:ListItem>1977</asp:ListItem>
                                                    <asp:ListItem>1978</asp:ListItem>
                                                    <asp:ListItem>1979</asp:ListItem>
                                                    <asp:ListItem>1980</asp:ListItem>
                                                    <asp:ListItem>1981</asp:ListItem>
                                                    <asp:ListItem>1982</asp:ListItem>
                                                    <asp:ListItem>1983</asp:ListItem>
                                                    <asp:ListItem>1984</asp:ListItem>
                                                    <asp:ListItem>1985</asp:ListItem>
                                                    <asp:ListItem>1986</asp:ListItem>
                                                    <asp:ListItem>1987</asp:ListItem>
                                                    <asp:ListItem>1988</asp:ListItem>
                                                    <asp:ListItem>1989</asp:ListItem>
                                                    <asp:ListItem>1990</asp:ListItem>
                                                    <asp:ListItem>1991</asp:ListItem>
                                                    <asp:ListItem>1992</asp:ListItem>
                                                    <asp:ListItem>1993</asp:ListItem>
                                                    <asp:ListItem>1994</asp:ListItem>
                                                    <asp:ListItem>1995</asp:ListItem>
                                                    <asp:ListItem>1996</asp:ListItem>
                                                    <asp:ListItem>1997</asp:ListItem>
                                                    <asp:ListItem>1998</asp:ListItem>
                                                    <asp:ListItem>1999</asp:ListItem>
                                                    <asp:ListItem>2000</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
										<TR>
											<TD>
												Parent Name</TD>
											<TD class="style1">
												<asp:textbox id="TextBox_Parent" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" 
                                                    ErrorMessage="*" ControlToValidate="TextBox_Parent" ForeColor="Red" 
                                                    ValidationGroup="a"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD>
												Gender</TD>
											<TD class="style1">
												<asp:dropdownlist id="DropDownList_Gender" runat="server" Width="88px" CssClass="txtBox">
													<asp:ListItem Value="Male">Male</asp:ListItem>
													<asp:ListItem Value="Female">Female</asp:ListItem>
												</asp:dropdownlist></TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<TR>
											<TD colspan="3">
												&nbsp;</TD>
										</TR>
										<tr>
                                            <td colspan="3">
                                                <strong>Course Information</strong></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td class="style1">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Course</td>
                                            <td class="style1">
                                                <asp:DropDownList ID="ddlCourses" runat="server" 
                                                    onselectedindexchanged="ddlCourses_SelectedIndexChanged" AutoPostBack="True" 
                                                   >
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
										<TR>
											<TD>
												Semester</TD>
											<TD class="style1">
												<asp:dropdownlist id="DropDownList_Sem" runat="server" Width="64px" CssClass="txtBox"></asp:dropdownlist></TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<TR>
											<TD>
												&nbsp;</TD>
											<TD class="style1">
												&nbsp;</TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<tr>
                                            <td colspan="3">
                                                <strong>Contact Information</strong></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Emailid</td>
                                            <td class="style1">
                                                <asp:TextBox ID="TextBox_Email" runat="server" CssClass="txtBox"></asp:TextBox>
                                                <br />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                                    ControlToValidate="TextBox_Email" 
                                                    ErrorMessage="Email ID should be in standard format" ForeColor="Red" 
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                    ValidationGroup="a"></asp:RegularExpressionValidator>
                                            </td>
                                            <td>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                    ControlToValidate="TextBox_Email" ErrorMessage="*" 
                                                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                    ForeColor="Red" ValidationGroup="a"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                Mobile</td>
                                            <td class="style3">
                                                <asp:TextBox ID="TextBox_Mobile" runat="server" CssClass="txtBox"></asp:TextBox>
                                                <br />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                    ControlToValidate="TextBox_Mobile" 
                                                    ErrorMessage="Mobile num should be 10 digits" ForeColor="Red" 
                                                    ValidationExpression="\d{10}" ValidationGroup="a"></asp:RegularExpressionValidator>
                                            </td>
                                            <td class="style2">
                                                </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                &nbsp;</td>
                                        </tr>
										<TR>
											<TD>
												Password</TD>
										    <td class="style1">
                                                <asp:TextBox ID="TextBox_Password" runat="server" CssClass="txtBox" 
                                                    TextMode="Password"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                    ControlToCompare="TextBox_Password" ControlToValidate="TextBox_Confirn" 
                                                    ErrorMessage="*" ForeColor="Red" ValidationGroup="a"></asp:CompareValidator>
                                            </td>
										</TR>
										<tr>
                                            <td>
                                                Comfirm</td>
                                            <td class="style1">
                                                <asp:TextBox ID="TextBox_Confirn" runat="server" CssClass="txtBox" 
                                                    TextMode="Password"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
										<TR>
											<TD>
												Status</TD>
											<TD class="style1">
                                                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="txtBox" Width="88px">
                                                    <asp:ListItem>Current</asp:ListItem>
                                                    <asp:ListItem>Old</asp:ListItem>
                                                </asp:DropDownList>
                                            </TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<TR>
											<TD>
												Result<br /> (Only for Old Student)</TD>
											<TD class="style1">
												<asp:DropDownList ID="ddlPStatus" runat="server" CssClass="txtBox" 
                                                    
                                                    Width="88px">
                                                    <asp:ListItem>None</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Excellent</asp:ListItem>
                                                    <asp:ListItem>Bad</asp:ListItem>
                                                    <asp:ListItem>Average</asp:ListItem>
                                                </asp:DropDownList>
                                            </TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<TR>
											<TD>
												&nbsp;</TD>
											<TD class="style1">
												&nbsp;</TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<TR>
											<TD>
												&nbsp;</TD>
											<TD class="style1">
												<asp:Button ID="btnReggggg" runat="server" CssClass="Button_Click" 
                                                    onclick="btnReggggg_Click" Text="Register" ValidationGroup="a" />
                                            </TD>
											<TD>
												&nbsp;</TD>
										</TR>
									    <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td class="style1">
                                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									</TABLE>
								    <br />
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				
			</TABLE>

            </div>
             </asp:Panel>

</asp:Content>
