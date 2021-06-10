<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XBDAppPortalList.aspx.cs" Inherits="XBDAppPortalWebFormAppPrj.XBDAppPortalList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ribo Web Portal List</title>
    <style>
        #portalList {
            max-width:1200px;
            margin:2px auto;
            background-color:aquamarine;
            padding-top:30px;
            padding-bottom:50px;

        }
        #portalList #grvXbdAppList {
            margin:2px auto;
        }
        #portalList #grvXbdAppList tr td, th {
            padding:12px;
        }
        #portalList .filterWrap {
            padding:10px;
    /*        border-radius:10px;*/
            margin-bottom:10px;
            margin:2px auto;
            max-width: 450px;        
    

    
        }

        #portalList .filterWrap .filter {
            padding:10px;
            border-radius:10px;
            margin-bottom:10px;
        }
            #portalList .header {
                margin:30px auto;
                max-width: 400px; 
                font-weight:bold;
                font-size:22px;

            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="portalList">
            <div class="header">Welcome to Ribo App Portals</div>
            <div class="filterWrap">
                <asp:DropDownList ID="ddlAppName" runat="server" OnDataBinding="ddlAppName_DataBinding" class="filter" OnSelectedIndexChanged="ddlAppName_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList>
                <asp:DropDownList ID="ddlAppType" runat="server"  OnDataBinding="ddlAppType_DataBinding" class="filter"></asp:DropDownList>
                <asp:Button ID="btnFilter" Text="Go" CssClass="filter" runat="server" OnClick="btnFilter_Click" />
            </div>
            
            
            <asp:GridView ID="grvXbdAppList" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="AppId" HeaderText="AppId" ControlStyle-CssClass="portalRow" />
                    <asp:BoundField DataField="AppName" HeaderText ="App Name" ItemStyle-CssClass="portalRow" />
                    <asp:BoundField DataField="AppDes" HeaderText ="App Description" />
                    <asp:BoundField DataField="AppTypeId" HeaderText="AppTypeId" />
                    <asp:BoundField DataField="AppType" HeaderText="AppType" AccessibleHeaderText="aaa" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
