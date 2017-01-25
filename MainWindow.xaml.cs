using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HelpdeskOperationsTools
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent1();
        }

        public static string GetProperty(SearchResult searchResult, string propertyName)
        {
            return searchResult.Properties.Contains(propertyName)
                ? searchResult.Properties[propertyName][0].ToString()
                : string.Empty;
        }

        private void btnADClearInformation_Click(object sender, RoutedEventArgs e)
        {
            TbxAdLoginId.Text = "";
            TbxAdDistinguishedName.Text = "";
            TbxAdDescription.Text = "";
            TbxAdCustomerId.Text = "";
            TbxFullName.Text = "";
            TbxAdDisplayName.Text = "";
            TbxAdEmailAddress.Text = "";
            TbxAdPasswordLastSet.Text = "";
            TbxAdPasswordLastSet.Background = Brushes.White;
            TbxAdAccountEnabled.Text = "";
            TbxAdAccountEnabled.Background = Brushes.White;
            TbxAdIsAccountLocked.Text = "";
            TbxAdIsAccountLocked.Background = Brushes.White;
            TbxAcctExpiration.Text = "";
            TbxAcctExpiration.Background = Brushes.White;
            TbxAdLoginScript.Text = "";
            TbxAdHomeDriveLetter.Text = "";
            TbxAdHomeFolder.Text = "";
            TbxTitle.Text = "";
            TbxWhenCreated.Text = "";
            TbxWhenChanged.Text = "";
            TbxVcSifRefId.Text = "";
            TbxVcJobCode.Text = "";
            TbxDepartment.Text = "";
            TbxCompany.Text = "";
            TbxTelephoneNumber.Text = "";
            TbxLastLogon.Text = "";
            TbxBadPasswordTime.Text = "";
            DgDisplayGroups.ItemsSource = "";
        }

        private void btnADDisplayInformation_Click(object sender, RoutedEventArgs e)
        {
            TbxAdDistinguishedName.Text = "";
            TbxAdDescription.Text = "";
            TbxAdCustomerId.Text = "";
            TbxFullName.Text = "";
            TbxAdDisplayName.Text = "";
            TbxAdEmailAddress.Text = "";
            TbxAdPasswordLastSet.Text = "";
            TbxAdPasswordLastSet.Background = Brushes.White;
            TbxAdAccountEnabled.Text = "";
            TbxAdAccountEnabled.Background = Brushes.White;
            TbxAdIsAccountLocked.Text = "";
            TbxAdIsAccountLocked.Background = Brushes.White;
            TbxAcctExpiration.Text = "";
            TbxAcctExpiration.Background = Brushes.White;
            TbxAdLoginScript.Text = "";
            TbxAdHomeDriveLetter.Text = "";
            TbxAdHomeFolder.Text = "";
            TbxTitle.Text = "";
            TbxWhenCreated.Text = "";
            TbxWhenChanged.Text = "";
            TbxVcSifRefId.Text = "";
            TbxVcJobCode.Text = "";
            TbxDepartment.Text = "";
            TbxCompany.Text = "";
            TbxTelephoneNumber.Text = "";
            TbxLastLogon.Text = "";
            TbxBadPasswordTime.Text = "";
            DgDisplayGroups.ItemsSource = "";
            if (string.IsNullOrEmpty(TbxAdLoginId.Text))
            {
                MessageBox.Show("Enter Login ID", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                var byIdentity = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain),
                    IdentityType.SamAccountName, TbxAdLoginId.Text);
                if (byIdentity != null)
                {
                    TbxAdDistinguishedName.Text = byIdentity.DistinguishedName;
                    TbxAdDescription.Text = byIdentity.Description;
                    TbxAdCustomerId.Text = byIdentity.EmployeeId;
                    TbxFullName.Text = byIdentity.GivenName + " " + byIdentity.MiddleName + " " +
                                       byIdentity.Surname;
                    TbxAdDisplayName.Text = byIdentity.DisplayName;
                    TbxAdEmailAddress.Text = byIdentity.EmailAddress;
                    TbxAdPasswordLastSet.Text =
                        byIdentity.LastPasswordSet?.ToLocalTime().ToString(CultureInfo.InvariantCulture) ??
                        "Password never set";
                    var enabled = byIdentity.Enabled;
                    if ((enabled.GetValueOrDefault() ? 0 : (enabled.HasValue ? 1 : 0)) != 0)
                        TbxAdAccountEnabled.Background = Brushes.LightSalmon;
                    TbxAdAccountEnabled.Text = byIdentity.Enabled.ToString();
                    if (byIdentity.IsAccountLockedOut())
                    {
                        TbxAdIsAccountLocked.Background = Brushes.LightSalmon;
                        TbxAdIsAccountLocked.Text = "Yes";
                    }
                    else
                        TbxAdIsAccountLocked.Text = "No";
                    if (byIdentity.AccountExpirationDate.HasValue)
                    {
                        TbxAcctExpiration.Text =
                            byIdentity.AccountExpirationDate.Value.ToLocalTime().ToString(CultureInfo.InvariantCulture);
                        var accountExpirationDate = byIdentity.AccountExpirationDate;
                        var now = DateTime.Now;
                        TbxAcctExpiration.Background = (accountExpirationDate.GetValueOrDefault() < now ? 1 : 0) != 0
                            ? Brushes.LightSalmon
                            : Brushes.LightGreen;
                    }
                    else
                        TbxAcctExpiration.Text = "Does not expire";
                    TbxAdLoginScript.Text = byIdentity.ScriptPath;
                    TbxAdHomeDriveLetter.Text = byIdentity.HomeDrive;
                    TbxAdHomeFolder.Text = byIdentity.HomeDirectory;
                    var groups = byIdentity.GetGroups();
                    var stringContainerList =
                        groups.Select(principal => new StringContainer(principal.SamAccountName)).ToList();
                    DgDisplayGroups.ItemsSource = stringContainerList;
                    var all =
                        DomainController.FindAll(new DirectoryContext(DirectoryContextType.Domain, "dcps"),
                            ActiveDirectorySite.GetComputerSite().Name);
                    foreach (DomainController domainController in all)
                    {
                        var directorySearcher =
                            new DirectorySearcher(
                                new DirectoryEntry("LDAP://" + domainController + "/dc=dcps,dc=duval,dc=us"));
                        var text = TbxAdLoginId.Text;
                        directorySearcher.Filter = "(&(objectClass=user)(sAMAccountName=" + text + "))";
                        foreach (SearchResult searchResult in directorySearcher.FindAll())
                        {
                            TbxTitle.Text = GetProperty(searchResult, "title");
                            TbxWhenCreated.Text =
                                DateTime.Parse(GetProperty(searchResult, "whenCreated"))
                                    .ToLocalTime()
                                    .ToString(CultureInfo.InvariantCulture);
                            TbxWhenChanged.Text =
                                DateTime.Parse(GetProperty(searchResult, "whenChanged"))
                                    .ToLocalTime()
                                    .ToString(CultureInfo.InvariantCulture);
                            TbxVcSifRefId.Text = GetProperty(searchResult, "VcSIFRefID");
                            TbxVcJobCode.Text = GetProperty(searchResult, "VcJobCode");
                            TbxDepartment.Text = GetProperty(searchResult, "department");
                            TbxCompany.Text = GetProperty(searchResult, "company");
                            TbxTelephoneNumber.Text = GetProperty(searchResult, "telephoneNumber");
                            TbxLastLogon.Text = "Feature No Longer Available";
                            TbxBadPasswordTime.Text = "Feature No Longer Available";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID Not Found", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

        private void btnResetPassword_Click(object sender, RoutedEventArgs e)
        {
            var byIdentity = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain),
                IdentityType.SamAccountName, TbxAdLoginId.Text);
            var lineLength = TbxAdCustomerId.GetLineLength(0);
            if (byIdentity == null)
                return;
            if (lineLength < 6)
            {
                var num1 =
                    (int)
                    MessageBox.Show("Customer ID must be at least 6 digits", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
            }
            else
            {
                try
                {
                    byIdentity.SetPassword("Pw" + TbxAdCustomerId.Text.Trim());
                    byIdentity.ExpirePasswordNow();
                    MessageBox.Show("Password reset to Pw" + TbxAdCustomerId.Text.Trim(),
                        "Password Reset Successfully", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                catch (PasswordException)
                {
                    MessageBox.Show(
                        "Password does not meet complexity requirements. Customer ID must contain at least one number or special character.",
                        "Password Reset Error", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btnUnlockAccount_Click(object sender, RoutedEventArgs e)
        {
            var byIdentity = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain),
                IdentityType.SamAccountName, TbxAdLoginId.Text);
            try
            {
                byIdentity.UnlockAccount();
            }
            catch
            {
            }
        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        [DebuggerNonUserCode]
        public void InitializeComponent1()
        {
            if (_contentLoaded)
                return;
            _contentLoaded = true;
            Application.LoadComponent(this,
                new Uri("/Helpdesk Operations Tools - Reduced Functionality Version;component/mainwindow.xaml",
                    UriKind.Relative));
        }


        public class StringContainer
        {
            public string Group { get; set; }

            public StringContainer(string value)
            {
                Group = value;
            }
        }
    }
}