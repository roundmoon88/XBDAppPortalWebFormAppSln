using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XBDAppPortalWebFormApp.BLL;
using XBDAppWebFormApp.DTO;

namespace XBDAppPortalWebFormAppPrj
{
    public partial class XBDAppPortalList : System.Web.UI.Page
    {
        private XBDAppPortalListBLL xBDAppPortalListBLL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               var ret = GetPortals();
                grvXbdAppList.DataSource = ret;
                grvXbdAppList.DataBind();
                LoadFilter();
            }
        }
        private IList<XDbAppDTO> GetPortals()
        {

            //System.Diagnostics.Debug.WriteLine("Hi there99!");
            xBDAppPortalListBLL = new XBDAppPortalListBLL();
            return xBDAppPortalListBLL.GetXBDAppList();
        }
        private void LoadFilter()
        {
            
            ddlAppName.DataBind();
            ddlAppType.DataBind();

        }

        protected void ddlAppName_DataBinding(object sender, EventArgs e)
        {
            var appFilterList = xBDAppPortalListBLL.FilterGet(FilterEnum.App);
            ddlAppName.Items.Clear();
            ddlAppName.Items.Add(new ListItem { Value = "0", Text = "All Apps" });
            foreach (var item in appFilterList)
            {
                ListItem item1 = new ListItem();
                item1.Text = item.Item;
                item1.Value = item.ItemId.ToString();
                ddlAppName.Items.Add(item1);
            }


        }

        protected void ddlAppType_DataBinding(object sender, EventArgs e)
        {
            var appTypeFilterList = xBDAppPortalListBLL.FilterGet(FilterEnum.AppType);
            ddlAppType.Items.Clear();
            ddlAppType.Items.Add(new ListItem { Value = "0", Text = "All App Types" });
            foreach (var item in appTypeFilterList)
            {
                ListItem item1 = new ListItem();
                item1.Text = item.Item;
                item1.Value = item.ItemId.ToString();
                ddlAppType.Items.Add(item1);
            }
        }

        //this moethod will be removed later. check in test again. one more try. second try, the third try. fourth try, five
        protected void ddlAppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectAppName = this.ddlAppName.SelectedValue;
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            xBDAppPortalListBLL = new XBDAppPortalListBLL();
            var selectedApp = this.ddlAppName.SelectedValue;
            var selectedAppType = this.ddlAppType.SelectedValue;
            IList<FilterDTO> filters = new List<FilterDTO>();
            FilterDTO filter = new FilterDTO
            {
                ItemId = Convert.ToInt32(selectedApp),
                Selected = true,
                FilterName = FilterEnum.App
            };
            filters.Add(filter);

            filter = new FilterDTO
            {
                ItemId = Convert.ToInt32(selectedAppType),
                Selected = true,
                FilterName = FilterEnum.AppType
            };
            filters.Add(filter);
            var result = xBDAppPortalListBLL.GetXBDAppListByFilter(filters);
            this.grvXbdAppList.DataSource = result;
            this.grvXbdAppList.DataBind();
        }
    }
}