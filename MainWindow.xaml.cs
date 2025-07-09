using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Part3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int numIng = 0; //The varieble for the sizes of the arrays which is number of ingredients.
        static int numSteps = 0; //The varieble to set the array of description which is number of steps.
        static int numRec = 0;// The variable for the number of recipes
        double totCal = 0;// The variable for total number of calories
        int countEnter = 0; //The variable for keeping count when enter is pressed
        int order; //The variable the will determine the array number
        int contantNum = 0; //The variable for changing the recipe name when inputing ingrediants
        int displayCount = 1; //The variable that keeps count for contantNum
        int addCount = 0; 
        int contant = 0;
        int scaleResult;
        int resetResponse; // The variable for the respose from the user if the arrays should reset 
        Dictionary<string, int> myDictionary;
        SortedList RecName;
        ArrayList ingrediants;
        List<double> quantity;
        List<string> measurement;
        List<string> stepDescription;
        List<string> food;
        List<double> calories;
        public MainWindow()
        {
            InitializeComponent();

            // Declaring the arrays
            ingrediants = new ArrayList();
            quantity = new List<double>();
            measurement = new List<string>();
            stepDescription = new List<string>();
            myDictionary = new Dictionary<string, int>();
            RecName = new SortedList();
            food = new List<string>();
            calories = new List<double>();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //When enter is pressed other components will be made visible and other invisible
            numRec = Convert.ToInt32(recNum.Text);
            numIng = Convert.ToInt32(ingNum.Text);
            recNum.Visibility = Visibility.Collapsed;
            ingNum.Visibility = Visibility.Collapsed;
            textBlockIngNum.Visibility = Visibility.Collapsed;
            textBlockRecNum.Visibility = Visibility.Collapsed;
            enter.Visibility = Visibility.Collapsed;
            textBoxRecipeName.Visibility = Visibility.Visible;
            recipeName.Visibility = Visibility.Visible;
            textBoxIngrediantName.Visibility = Visibility.Visible;
            ingrediantName.Visibility = Visibility.Visible;
            buttonRecipeName.Visibility = Visibility.Visible;
            textBoxEnterRecipe.Visibility = Visibility.Visible;
            textBoxQuantity.Visibility = Visibility.Visible;
            ingrediantQuantity.Visibility = Visibility.Visible;
            textBoxMeasurement.Visibility = Visibility.Visible;
            ingrediantMeasurement.Visibility = Visibility.Visible;
            textBoxFoodGroup.Visibility = Visibility.Visible;
            textBoxCalories.Visibility = Visibility.Visible;
            ingrediantFoodGroup.Visibility = Visibility.Visible;
            ingrediantCalories.Visibility = Visibility.Visible;
            textBoxNumSteps.Visibility = Visibility.Visible;
            ingrediantNumSteps.Visibility = Visibility.Visible;
            enterRecipe.Visibility = Visibility.Visible;
            print.Visibility = Visibility.Visible;
            ingrediantScale.Visibility = Visibility.Visible;
            enterScale.Visibility = Visibility.Visible;
            textBoxScale.Visibility = Visibility.Visible;
            textBoxSearch.Visibility = Visibility.Visible;
            searchItem.Visibility = Visibility.Visible;
            searchButton.Visibility = Visibility.Visible;
            resetScale.Visibility = Visibility.Visible;
            textBoxReset.Visibility = Visibility.Visible;
            textBoxResetRecipe.Visibility = Visibility.Visible;
            resetRecipe.Visibility = Visibility.Visible;
            textBoxFilter.Visibility = Visibility.Visible;
            textBoxFilterItem.Visibility = Visibility.Visible;
            filterItem.Visibility = Visibility.Visible;
            textBoxMax.Visibility = Visibility.Visible;
            enterFilterItem.Visibility = Visibility.Visible;
            maxItem.Visibility = Visibility.Visible;
        }
        public void populate(ref ArrayList ingrediants, List<double> quantity, List<string> measurement, List<string> stepDescription, SortedList RecName, List<string> food, List<double> calories)
        //This method is to set all values of the list
        {

        }

        private void buttonRecipeName_Click(object sender, RoutedEventArgs e)
        {

        // When enter is pressed the recipe array will be populated
                textBoxRecipeName.Text = "Enter recipe " +( RecName.Count+1) + " name";
                try
                {
                    RecName.Add(recipeName.Text, addCount);
                }
                catch (Exception ex)
                {

                }
            addCount++;
            //The if statment is to display a popup message when the correct number of recipes have been entered
            if (RecName.Count == numRec)
            { 
                buttonRecipeName.IsEnabled = false;
                string messageBoxText = "You have entered enough recepies";
                string caption = "Word Processor";
                MessageBoxButton button = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            textBoxEnterRecipe.Text = "Enter recipe 1 name";
        }

        private void enterRecipe_Click(object sender, RoutedEventArgs e)
        {
           //When entered is pressed all data in the text boxes will be entered to an array 
            displayCount++;
            try
            {
                textBoxEnterRecipe.Text = "Enter recipe " + RecName.GetKey(RecName.IndexOfValue(contant)) + " name";
            }
            catch (Exception ex)
            {

            }
            if (displayCount%numIng==0) {
                contant++;
            }
           
                try
                {


                    textBoxIngrediantName.Text = "Enter name of ingredient " + (countEnter + 1);
                    ingrediants.Add(ingrediantName.Text);


                    textBoxQuantity.Text = "Enter quantity of ingredient " + (countEnter + 1);
                    quantity.Add(Convert.ToInt32(ingrediantQuantity.Text));

                    textBoxMeasurement.Text = "Enter ingredient measurement of " + (countEnter + 1);
                    measurement.Add(ingrediantMeasurement.Text);

                    textBoxFoodGroup.Text = "Enter food group of ingredient " + (countEnter + 1);
                    food.Add(ingrediantFoodGroup.Text);

                    textBoxCalories.Text = "Enter number of calories " + (countEnter + 1);
                    calories.Add(Convert.ToInt32(ingrediantCalories.Text));

                    textBoxNumSteps.Text = "Enter number of steps";
                    numSteps = Convert.ToInt32(ingrediantNumSteps.Text);




                }
                catch (Exception)
                {

                }


            

            countEnter++;
            textBoxSteps.Visibility = Visibility.Visible;
            steps.Visibility = Visibility.Visible;
            enterSteps.Visibility = Visibility.Visible;
            enterSteps.IsEnabled = true;
            textBoxSteps.Text = "Enter " + numSteps.ToString() + " steps";

        //The if statment is to display a popup message when the correct number of ingrediants have been entered

            if (numIng*numRec==ingrediants.Count)
            {
                enterRecipe.IsEnabled = false;
                string messageBoxText = "You have entered enough ingrediants.";
                string caption = "Word Processor";
                MessageBoxButton button = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            }
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {




        }

        private void print_Click_1(object sender, RoutedEventArgs e)
        {
            //When the print button is clicked all arrays will be displayed in order
            for (int f = 0; f < numRec; f++)
            {
                order = (int)RecName.GetByIndex(f);
                listBox.Items.Add("*************************");
                listBox.Items.Add("For recipe " + (f + 1));
                listBox.Items.Add(RecName.GetKey(f));
                listBox.Items.Add("Array num " + order);
                totCal = 0;

                order = order * numIng;
                for (int i = 0; i < numIng; i++)
                {
                    listBox.Items.Add("For recipe " + (f + 1));
                    listBox.Items.Add(RecName.GetKey(f));
                    listBox.Items.Add("*************************");


                    try
                    {
                        listBox.Items.Add("Array num " + order);
                        listBox.Items.Add("Ingrediant " + (i + 1) + " is " + ingrediants[order]);
                        listBox.Items.Add("The quantity for " + ingrediants[order] + " is " + quantity[order]);
                        listBox.Items.Add("The unit of measurement for " + ingrediants[order] + " is " + measurement[order]);
                        listBox.Items.Add("The food group for " + ingrediants[order] + " is " + food[order]);

                    }
                    catch (Exception ex) { }

                    for (int j = 0; j < stepDescription.Count; j++) { listBox.Items.Add("Steps of recipe :" + stepDescription[j]); }

                    order++;


                    try { 
                    totCal = totCal + calories[i + (numIng * f)];

                    listBox.Items.Add("*************************");
                    listBox.Items.Add("The total calories is: " + totCal);
                }catch (Exception ex) { }
                  if (totCal > 300)
                  {
                      listBox.Items.Add("The calories exeed 300 calories");
                  }

                   
                }

            }
        }

        private void enterSteps_Click(object sender, RoutedEventArgs e)
        {
            //This method is for populating the steps array
            
                textBoxSteps.Text = ("Enter step " + (stepDescription.Count+1) + " description");
                stepDescription.Add(steps.Text);
            
            if (numSteps == stepDescription.Count)
            {
                enterSteps.IsEnabled = false;
            }
        }
        

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            //When the search button is clicked the list box will be cleared and the searched array will be displayed
            listBox.Items.Clear();
            string search= searchItem.Text;
            for (int i = 0; i < RecName.Count; i++) {
                if (search == (string)RecName.GetKey(i)) {
                    int order = (int)RecName.GetByIndex(i);
                    listBox.Items.Add("For recipe " + (i + 1));
                    listBox.Items.Add(RecName.GetKey(i));
                    listBox.Items.Add("*************************");
                    for (int j=numIng*i;j<numIng;j++) {


                        try
                        {
                            listBox.Items.Add("Array num " + j);
                            listBox.Items.Add("Ingrediant " + (i + 1) + " is " + ingrediants[j]);
                            listBox.Items.Add("The quantity for " + ingrediants[j] + " is " + quantity[j]);
                            listBox.Items.Add("The unit of measurement for " + ingrediants[j] + " is " + measurement[j]);
                            listBox.Items.Add("The food group for " + ingrediants[j] + " is " + food[j]);
                        }
                        catch (Exception ex) { }

                        for (int k = 0; k < stepDescription.Count; k++) { listBox.Items.Add("Steps of recipe :" + stepDescription[k]); }
                        listBox.Items.Add("*************************");
                    }
                } }
        }

        private void enterScale_Click(object sender, RoutedEventArgs e)// This method is for the user to change the scale of the quantity of the ingredients 
        {

             scaleResult = Convert.ToInt32(ingrediantScale.Text);
            try
            {
                switch (scaleResult)
                {
                    case 1:
                        for (int i = 0; i < numIng; i++)
                        {
                            quantity[i] = Convert.ToInt32(quantity[i]) * 2;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < numIng; i++)
                        {
                            quantity[i] = Convert.ToInt32(quantity[i]) / 2;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < numIng; i++)
                        {
                            quantity[i] = Convert.ToInt32(quantity[i]) * 3;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;

                }
            }
            catch (Exception ex) { }


        }
        private void resetScale_Click(object sender, RoutedEventArgs e)
        {
         

        }

        private void resetScale_Click_1(object sender, RoutedEventArgs e)//This method will reset all scales
        {
            switch (scaleResult)
            {
                case 1:
                    for (int i = 0; i < numIng; i++)
                    {
                        quantity[i] = Convert.ToInt32(quantity[i]) / 2;
                    }
                    break;
                case 2:
                    for (int i = 0; i < numIng; i++)
                    {
                        quantity[i] = Convert.ToInt32(quantity[i]) * 2;
                    }
                    break;
                case 3:
                    for (int i = 0; i < numIng; i++)
                    {
                        quantity[i] = Convert.ToInt32(quantity[i]) / 3;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;



            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //When the reset button is pressed all arrays will be cleared and components will change visibility
            //All variable will be reset back to 0
            recNum.Visibility = Visibility.Visible;
            ingNum.Visibility = Visibility.Visible;
            textBlockIngNum.Visibility = Visibility.Visible;
            textBlockRecNum.Visibility = Visibility.Visible;
            enter.Visibility = Visibility.Visible;
            textBoxRecipeName.Visibility = Visibility.Collapsed;
            recipeName.Visibility = Visibility.Collapsed;
            textBoxIngrediantName.Visibility = Visibility.Collapsed;
            ingrediantName.Visibility = Visibility.Collapsed;
            buttonRecipeName.Visibility = Visibility.Collapsed;
            textBoxEnterRecipe.Visibility = Visibility.Collapsed;
            textBoxQuantity.Visibility = Visibility.Collapsed;
            ingrediantQuantity.Visibility = Visibility.Collapsed;
            textBoxMeasurement.Visibility = Visibility.Collapsed;
            ingrediantMeasurement.Visibility = Visibility.Collapsed;
            textBoxFoodGroup.Visibility = Visibility.Collapsed;
            textBoxCalories.Visibility = Visibility.Collapsed;
            ingrediantFoodGroup.Visibility = Visibility.Collapsed;
            ingrediantCalories.Visibility = Visibility.Collapsed;
            textBoxNumSteps.Visibility = Visibility.Collapsed;
            ingrediantNumSteps.Visibility = Visibility.Collapsed;
            enterRecipe.Visibility = Visibility.Collapsed;
            print.Visibility = Visibility.Collapsed;
            ingrediantScale.Visibility = Visibility.Collapsed;
            enterScale.Visibility = Visibility.Collapsed;
            textBoxScale.Visibility = Visibility.Collapsed;
            textBoxSearch.Visibility = Visibility.Collapsed;
            searchItem.Visibility = Visibility.Collapsed;
            searchButton.Visibility = Visibility.Collapsed;
            resetScale.Visibility = Visibility.Collapsed;
            textBoxReset.Visibility = Visibility.Collapsed;
            textBoxResetRecipe.Visibility = Visibility.Collapsed;
            resetRecipe.Visibility = Visibility.Collapsed;
            textBoxFilter.Visibility = Visibility.Collapsed;
            textBoxFilterItem.Visibility = Visibility.Collapsed;
            filterItem.Visibility = Visibility.Collapsed;
            textBoxMax.Visibility = Visibility.Collapsed;
            enterFilterItem.Visibility = Visibility.Collapsed;
            maxItem.Visibility = Visibility.Collapsed;
            textBoxSteps.Visibility = Visibility.Collapsed;
            steps.Visibility = Visibility.Collapsed;
            enterSteps.Visibility = Visibility.Collapsed;

            ingrediants.Clear();
            quantity.Clear();
            measurement.Clear();
            stepDescription.Clear();
            RecName.Clear();
            food.Clear();
            calories.Clear();
            listBox.Items.Clear();

            countEnter = 0;
            order=0;
            contantNum = 0;
            displayCount = 1;
            addCount = 0;
            contant = 0;
            scaleResult=0;
            countEnter = 0;
            totCal = 0;
            numIng = 0; 
            numSteps = 0;
            numRec = 0;

            buttonRecipeName.IsEnabled = true;
            enterRecipe.IsEnabled = true;

        }

        private void enterFilterItem_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            string search = filterItem.Text;
            for (int i = 0; i < numIng; i++)
            {
                if (search == (string)ingrediants[i] || search == (string)food[i])
                {
                 
                    listBox.Items.Add("For recipe " + (i/numRec + 1));
                    listBox.Items.Add(RecName.GetKey(i/numRec));
                    listBox.Items.Add("*************************");


                    try
                    {
                        listBox.Items.Add("Array num " + i);
                        listBox.Items.Add("Ingrediant " + (i + 1) + " is " + ingrediants[i]);
                        listBox.Items.Add("The quantity for " + ingrediants[i] + " is " + quantity[i]);
                        listBox.Items.Add("The unit of measurement for " + ingrediants[i] + " is " + measurement[i]);
                        listBox.Items.Add("The food group for " + ingrediants[i] + " is " + food[i]);
                    }
                    catch (Exception ex) { }

                    for (int j = 0; j < stepDescription.Count; j++) { listBox.Items.Add("Steps of recipe :" + stepDescription[j]); }
                    listBox.Items.Add("*************************");
                }
            }/*
            for (int i = 0; i < numIng; i++)
            {
                if (search == (string)food[i])
                {
                    int order = (int)RecName.GetByIndex(i);
                    listBox.Items.Add("For recipe " + ((i/numRec) + 1));
                    listBox.Items.Add(RecName.GetKey(i/numRec));
                    listBox.Items.Add("*************************");


                    try
                    {
                        listBox.Items.Add("Array num " + i);
                        listBox.Items.Add("Ingrediant " + (i + 1) + " is " + ingrediants[i]);
                        listBox.Items.Add("The quantity for " + ingrediants[i] + " is " + quantity[i]);
                        listBox.Items.Add("The unit of measurement for " + ingrediants[i] + " is " + measurement[i]);
                    }
                    catch (Exception ex) { }

                    for (int j = 0; j < stepDescription.Count; j++) { listBox.Items.Add("Steps of recipe :" + stepDescription[j]); }
                    listBox.Items.Add("*************************");
                }
            }*/
        }

        private void maxItem_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            int maxValue = (int)calories.Max();
            int maxIndex = calories.ToList().IndexOf(maxValue);

            listBox.Items.Add(maxIndex);
            listBox.Items.Add("Max value is: " + maxValue);
            try
            {
                listBox.Items.Add("For recipe " + (maxIndex + 1));
            listBox.Items.Add(RecName.GetKey((int)maxIndex/numRec));
            listBox.Items.Add("*************************");


           
                listBox.Items.Add("Array num " + maxIndex);
                listBox.Items.Add("Ingrediant " + (maxIndex + 1) + " is " + ingrediants[maxIndex]);
                listBox.Items.Add("The quantity for " + ingrediants[maxIndex] + " is " + quantity[maxIndex]);
                listBox.Items.Add("The unit of measurement for " + ingrediants[maxIndex] + " is " + measurement[maxIndex]);
                listBox.Items.Add("The food group for " + ingrediants[maxIndex] + " is " + food[maxIndex]);
            }
            catch (Exception ex) { }

            for (int j = 0; j < stepDescription.Count; j++) { listBox.Items.Add("Steps of recipe :" + stepDescription[j]); }
            listBox.Items.Add("*************************");
        
    }
    }   
    
}

