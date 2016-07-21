    using (PowerShell PowerShellInstance = PowerShell.Create())
    {
        PowerShellInstance.AddScript("param($param1) $d = get-date; $s = 'test string value'; " +
                "$d; $s; $param1; get-service");

        PowerShellInstance.AddParameter("param1", "parameter 1 value!");
    }
    
        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

    if (PowerShellInstance.Streams.Error.Count > 0)
    {
            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
    }

using System;
using Micrsoft.VisualStudio.TestTools.UnitTesting;

namespace AddItem
{
    [TC]
    public class auto
    public void auto1()
    {
        
    }
}

using System;
using OpenQA.Selenium;
using Caradigm.CM.UIAutomation.TaskLibrary.Common;
using System.Collections.ObjectModel;
using Caradigm.PlatformTest.AppFramework.Portals.TaskLibrary;



namespace Caradigm.CM.UIAutomation.TaskLibrary.UIOM
{

    internal class FindPatientOm
    {
        private readonly IWebDriver _driver;
        private IWebElement _mainElement;
        private IWebElement _firstNameTxtInput;
        private IWebElement _lastNameTxtInput;
        private IWebElement _findPatientBtn;
        private IWebElement _addPatientBtn;
        private IWebElement _patientNotListedLbl; 
        private ReadOnlyCollection<IWebElement> _processingElement;
        private IWebElement _addPatientfFirstNameTxtInput;
        private IWebElement _addPatientfLastNameTxtInput;
        private IWebElement _genderDropDownHeader;
        private IWebElement _communicationBarriersChkbox;
        private IWebElement _datePickerTxtInput;
        private IWebElement _datePickerMonthSelect;
        private IWebElement _datePickerYearSelect;
        private IWebElement _saveBtn;
        private IWebElement _addPatientWindow;
        private ReadOnlyCollection<IWebElement> _loadingElement;
        private IWebElement _spvName;
        private IWebElement _searchResultPatient;

        public FindPatientOm(IWebDriver driver)
        {
           _driver = driver;
        }
        public IWebElement MainElement
        {
            get
            {
                try
                {
                    TestUtility.WaitForElementToDisappear(ProcessingElement);
                    _mainElement = SeleniumHelper.FindElementWithWait(_driver, By.ClassName("cmd-lightbox-container"), Constants.ElementMaxLoadTime);
                }
                catch (WebDriverTimeoutException e)
                {
                    Console.WriteLine("WebDriverTimeoutException when looking for Main Element on FindPatient Window " + e.Message);
                    throw;
                }
                return _mainElement;
            }
        }

        public ReadOnlyCollection<IWebElement> ProcessingElement
        {
            get
            {
                _processingElement = _driver.FindElements(By.XPath(".//*[contains(@class, 'processing')]"));
                return _processingElement;
            }
        }

        public ReadOnlyCollection<IWebElement> LoadingElement
        {
            get
            {
                _loadingElement = _driver.FindElements(By.XPath(".//*[contains(@class, 'Loading')]"));
                return _loadingElement;
            }
        }

        public IWebElement FirstNameTxtInput
        {
            get
            {
                _firstNameTxtInput = MainElement.FindElement(By.XPath("//input[@type='text' and contains(@data-bind, 'firstName')]"));
                return _firstNameTxtInput;
            }
        }

        public IWebElement LastNameTxtInput
        {
            get
            {
                _lastNameTxtInput = MainElement.FindElement(By.XPath("//input[@type='text' and contains(@data-bind, 'lastName')]"));
                return _lastNameTxtInput;
            }
        }

        public IWebElement FindPatientBtn
        {
            get
            {
                _findPatientBtn = MainElement.FindElement(By.ClassName("cip-button-primary"));
                return _findPatientBtn;
            }
        }

        public IWebElement AddPatientBtn
        {
            get
            {
                _addPatientBtn = MainElement.FindElement(By.ClassName("cd-plu-addpatientbtn"));
                return _addPatientBtn;
            }
        }
        public IWebElement SearchResultPatient
        {
            get
            {

                _searchResultPatient = MainElement.FindElement(By.XPath("//*[@class = 'search-results-table cip-datatable-selectable dataTable no-footer']/tbody/tr[1]"));
                return _searchResultPatient;
            }
        }
        public IWebElement PatientNotListedLbl
        {
            get
            {
                _patientNotListedLbl = MainElement.FindElement(By.ClassName("//*[@class = 'lbl addpatientLabel']"));
                return _patientNotListedLbl;
            }
        }

        public IWebElement AddPatientWindow
        {
            get
            {
                try
                {
                    _addPatientWindow = SeleniumHelper.FindElementWithWait(_driver, By.ClassName("cip-content"), Constants.ElementMaxLoadTime);
                }
                catch (WebDriverTimeoutException e)
                {
                    Console.WriteLine("WebDriverTimeoutException when looking for Main Element on AddPatient Window" + e.Message);
                    throw;
                }
                return _addPatientWindow;
            }
        }

        public IWebElement AddpatientFirstNameTxtInput
        {
            get
            {
                _addPatientfFirstNameTxtInput = AddPatientWindow.FindElement(By.XPath("//div[@class = 'cip-form-field cip-addeditpatient-givenname']/input"));
                return _addPatientfFirstNameTxtInput;
            }
        }

        public IWebElement AddpatientLastNameTxtInput
        {
            get
            {
                _addPatientfLastNameTxtInput = AddPatientWindow.FindElement(By.XPath("//div[@class = 'cip-form-field cip-addeditpatient-lastname']/input"));
                return _addPatientfLastNameTxtInput;
            }
        }

        public IWebElement GenderDropDownHeader
        {
            get
            {
                _genderDropDownHeader = AddPatientWindow.FindElement(By.XPath("//*[@class ='cip-form-controlgroup cip-addeditpatient-gender']"));
                return _genderDropDownHeader;
            }
        }

        public IWebElement CommunicationBarriersChkbox
        {
            get
            {
                _communicationBarriersChkbox = AddPatientWindow.FindElement(By.XPath("//*[@id='cipAddEditPatientId0']"));
                return _communicationBarriersChkbox;
            }
        }
        public IWebElement DatePickerTxtInput
        {
            get
            {
                _datePickerTxtInput = AddPatientWindow.FindElement(By.XPath("//*[@class = 'cip-input-medium hasDatepicker']"));
                return _datePickerTxtInput;
            }
        }

        public IWebElement DatePickerMonthSelect
        {
            get
            {
                _datePickerMonthSelect = DatePickerTxtInput.FindElement(By.XPath("//*[@class = 'ui-datepicker-title']//select[1]"));
                return _datePickerMonthSelect;
            }
        }

        public IWebElement DatePickerYearSelect
        {
            get
            {
                _datePickerYearSelect = DatePickerTxtInput.FindElement(By.XPath("//*[@class = 'ui-datepicker-title']//select[2]"));
                return _datePickerYearSelect;
            }
        }

        public ReadOnlyCollection<IWebElement> DatePickerCalendar
        {
            get
            {
                IWebElement table = _driver.FindElement(By.ClassName("ui-datepicker-calendar"));
                ReadOnlyCollection<IWebElement> cells = table.FindElements(By.TagName("td"));
                return cells;
            }
        }

               
        public IWebElement SaveBtn
        {
            get
            {
                _saveBtn = AddPatientWindow.FindElement(By.XPath("//input[@value = 'Save' ]"));
                return _saveBtn;
            }
        }

        public IWebElement SPVName
        {
            get
            {
                _spvName = SeleniumHelper.FindElementWithWait(_driver, By.Id("ta_PbName"), Constants.ElementMaxLoadTime);
                return _spvName;
            }
        }
    }
}

