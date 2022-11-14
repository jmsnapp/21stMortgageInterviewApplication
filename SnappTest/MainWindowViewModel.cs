using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace SnappTest
{
    public class MainWindowViewModel : ObservableObject
    {
        private int[] intAryLarge = Array.Empty<int>();
        private int[] intAryEven = Array.Empty<int>();
        private int[] intAryOdd = Array.Empty<int>();
        private string _strInput = "Enter a comma separated list of integers";
        private string _strResult = string.Empty;

        public string InputString 
        {
            get { return _strInput; }

            set { SetProperty(ref _strInput, value); }

        }

        public string ResultString
        {
            get { return _strResult; }

            set { SetProperty(ref _strResult, value); }

        }

        public IRelayCommand GetMaxCommand { get; }
        public IRelayCommand SumEvenCommand { get; }
        public IRelayCommand SumOddCommand { get; }

        public MainWindowViewModel() 
        {
            GetMaxCommand = new RelayCommand(FindMax);
            SumEvenCommand = new RelayCommand(SumEven);
            SumOddCommand = new RelayCommand(SumOdd);

        }

        private void FindMax() 
        {
            string strReturn = string.Empty;

            try
            {
                ValidateInput();
                if (string.IsNullOrEmpty(ResultString))
                {
                    if (intAryLarge.Length > 0)
                    {
                        int intMax = intAryLarge[0];
                        foreach (int intItem in intAryLarge)
                        {
                            if (intItem > intMax)
                            { intMax = intItem; }

                        }

                        strReturn = intMax.ToString();

                    }

                }

                else 
                { strReturn = ResultString; }

            }

            catch (Exception ex)
            { strReturn = ex.Message; }

            ResultString = strReturn;

        }

        private void SumEven()
        {
            string strReturn = string.Empty;

            try
            {
                ValidateInput();
                if (string.IsNullOrEmpty(ResultString))
                {
                    if (intAryEven.Length > 0)
                    {
                        int intSum = 0;
                        foreach (int intItem in intAryEven)
                        { intSum += intItem; }

                        strReturn = intSum.ToString();

                    }

                    else
                    { strReturn = "No even numbers."; }

                }

                else
                { strReturn = ResultString; }

            }

            catch (Exception ex)
            { strReturn = ex.Message; }

            ResultString = strReturn;

        }

        private void SumOdd()
        {
            string strReturn = string.Empty;

            try
            {
                ValidateInput();
                if (string.IsNullOrEmpty(ResultString)) 
                {
                    if (intAryOdd.Length > 0)
                    {
                        int intSum = 0;
                        foreach (int intItem in intAryOdd)
                        { intSum += intItem; }

                        strReturn = intSum.ToString();

                    }

                    else
                    { strReturn = "No odd numbers."; }

                }

                else
                { strReturn = ResultString; }

            }

            catch (Exception ex)
            { strReturn = ex.Message; }

            ResultString = strReturn;

        }

        private void ValidateInput() 
        {
            ResultString = string.Empty;
            if (string.IsNullOrEmpty(_strInput) == false)
            {
                bool blnError = false;
                string[] strArray = _strInput.Split(',');
                intAryLarge = Array.Empty<int>();
                intAryEven = Array.Empty<int>();
                intAryOdd = Array.Empty<int>();
                foreach (string strItem in strArray) 
                {
                    if (string.IsNullOrEmpty(strItem) == false) 
                    {
                        int intItem;
                        if (int.TryParse(strItem, out intItem))
                        {
                            Array.Resize(ref intAryLarge, intAryLarge.Length + 1);
                            intAryLarge[intAryLarge.Length - 1] = intItem;

                            int intModTest = 0;
                            intModTest = intItem % 2;
                            if (intModTest == 0) 
                            {
                                Array.Resize(ref intAryEven, intAryEven.Length + 1);
                                intAryEven[intAryEven.Length - 1] = intItem;

                            } 

                            else 
                            {
                                Array.Resize(ref intAryOdd, intAryOdd.Length + 1);
                                intAryOdd[intAryOdd.Length - 1] = intItem;

                            }

                        }

                        else 
                        {
                            ResultString = "'" + strItem + "' is not an integer.";
                            blnError = true;
                            break;

                        }

                    }

                }

                if (blnError == false) 
                {
                    if (intAryLarge.Length < 1) 
                    { ResultString = "Input has no numbers."; }

                }

            }
            
            else 
            { ResultString = "Input is null or empty."; }

        }

    }

}
