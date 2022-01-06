using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseNetApplication
{
    public partial class courseNetApplicationForm : Form

    {   //GROUP DISCOUNT CONSTANT
        const decimal GROUP_DISCOUNT = 0.075m;

        //CERTIFICATE COST CONSTANT
        const decimal CERTIFICATE_COST = 39.99m;

        //ROOM UPGRADE COST CONSTANTS
        const decimal MASTER_SUITE_COST = 99.99m;
        const decimal JUNIOR_SUITE_COST = 59.99m;

        //COURSE COST CONSTANTS
        const decimal CSHARP_FUNDAMENTALS_COURSE_COST = 900.00m;
        const decimal CSHARP_BASICS_COURSE_COST = 1500.00m;
        const decimal CSHARP_INTERMEDIATE_COURSE_COST = 1800.00m;
        const decimal CSHARP_ADVANCED_COURSE_COST = 2300.00m;
        const decimal ASPNET_PARTA_COURSE_COST = 1250.00m;
        const decimal ASPNET_PARTB_COURSE_COST = 1250.00m;

        //COURSE TITLE CONSTANTS
        const string CSHARP_FUNDAMENTALS_COURSE_TITLE = "C# Fundamentals";
        const string CSHARP_BASICS_COURSE_TITLE = "C# Basics for Beginners";
        const string CSHARP_INTERMEDIATE_COURSE_TITLE = "C# Intermediate";
        const string CSHARP_ADVANCED_COURSE_TITLE = "C# Advanced Topics";
        const string ASPNET_PARTA_COURSE_TITLE = "ASP.NET with C# Part A";
        const string ASPNET_PARTB_COURSE_TITLE = "ASP.NET with C# Part B";

        //LOCATION COST CONSTANTS
        const decimal DUBLIN_COST = 99.99m;
        const decimal BELMULLET_COST = 219.99m;
        const decimal PARIS_COST = 149.99m;
        const decimal BERLIN_COST = 179.99m;
        const decimal VIENNA_COST = 149.99m;
        const decimal LISBON_COST = 89.99m;
        const decimal MADRID_COST = 229.99m;
        const decimal ROME_COST = 124.99m;
        const decimal AMSTERDAM_COST = 199.99m;

        //LOCATION TITLE CONSTANTS
        const string DUBLIN = "Dublin";
        const string BELMULLET = "Belmullet";
        const string PARIS = "Paris";
        const string BERLIN = "Berlin";
        const string VIENNA = "Vienna";
        const string LISBON = "Lisbon";
        const string MADRID = "Madrid";
        const string ROME = "Rome";
        const string AMSTERDAM = "AMSTERDAM";

        //GLOBAL VARIABLES
        private int summaryTotalBookings = 0;
        private decimal summaryTotalRegistrationFees = 0.0m;
        private decimal summaryTotalLodgingFees = 0.0m;
        private int summaryTotalDiscountedBookings = 0;
        private decimal summaryTotalCertificateAmount = 0.0m;
        private decimal summaryTotalRoomUpgradesAmount = 0.0m;
        private decimal summaryTotalRevenueAmount = 0.0m;
        private string currentLocation = "";

        public courseNetApplicationForm()
        {
            InitializeComponent();
        }

        //Event handler to display the booking selections made on the application
        private void displayFunctionButton_Click(object sender, EventArgs e)
        {
            decimal totalBookingCost = 0.0m;
            int totalParticipants = 0;
            decimal registrationCost = 0.0m;
            decimal lodgingCost = 0.0m;
            decimal certificateCost = 0.0m;

            int workshopIndex = 0;
            int locationIndex = 0;

            if (int.TryParse(participantsCountTextBox.Text, out totalParticipants) && totalParticipants > 0) {
                totalParticipantsTitleValueLabel.Text = participantsCountTextBox.Text;
                if (workshopSelectionListBox.SelectedIndex != -1)
                {
                    
                    if (locationSelectionListBox.SelectedIndex != -1)
                    {
                        locationIndex = locationSelectionListBox.SelectedIndex;
                        workshopIndex = workshopSelectionListBox.SelectedIndex;
                        switch (workshopIndex)
                        {
                            case 0:
                                registrationCost = CSHARP_FUNDAMENTALS_COURSE_COST * totalParticipants;
                                registrationCostTitleValueLabel.Text = registrationCost.ToString("c");
                                workshopTitleValueLabel.Text = CSHARP_FUNDAMENTALS_COURSE_TITLE;
                                totalBookingCost += registrationCost;
                                break;
                            case 1:
                                registrationCost = CSHARP_BASICS_COURSE_COST * totalParticipants;
                                registrationCostTitleValueLabel.Text = registrationCost.ToString("c");
                                workshopTitleValueLabel.Text = CSHARP_BASICS_COURSE_TITLE;
                                totalBookingCost += registrationCost;
                                break;
                            case 2:
                                registrationCost = CSHARP_INTERMEDIATE_COURSE_COST * totalParticipants;
                                registrationCostTitleValueLabel.Text = registrationCost.ToString("c");
                                workshopTitleValueLabel.Text = CSHARP_INTERMEDIATE_COURSE_TITLE;
                                totalBookingCost += registrationCost;
                                break;
                            case 3:
                                registrationCost = CSHARP_ADVANCED_COURSE_COST * totalParticipants;
                                registrationCostTitleValueLabel.Text = registrationCost.ToString("c");
                                workshopTitleValueLabel.Text = CSHARP_ADVANCED_COURSE_TITLE;
                                totalBookingCost += registrationCost;
                                break;
                            case 4:
                                registrationCost = ASPNET_PARTA_COURSE_COST * totalParticipants;
                                registrationCostTitleValueLabel.Text = registrationCost.ToString("c");
                                workshopTitleValueLabel.Text = ASPNET_PARTA_COURSE_TITLE;
                                totalBookingCost += registrationCost;
                                break;
                            case 5:
                                registrationCost = ASPNET_PARTB_COURSE_COST * totalParticipants;
                                registrationCostTitleValueLabel.Text = registrationCost.ToString("c");
                                workshopTitleValueLabel.Text = ASPNET_PARTB_COURSE_TITLE;
                                totalBookingCost += registrationCost;
                                break;
                            default:
                                break;
                        }

                        switch (locationIndex)
                        {
                            case 0:
                                lodgingCost = DUBLIN_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = DUBLIN;
                                break;
                            case 1:
                                lodgingCost = BELMULLET_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = BELMULLET;
                                break;
                            case 2:
                                lodgingCost = PARIS_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = PARIS;
                                break;
                            case 3:
                                lodgingCost = BERLIN_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = BERLIN;
                                break;
                            case 4:
                                lodgingCost = VIENNA_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = VIENNA;
                                break;
                            case 5:
                                lodgingCost = MADRID_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = MADRID;
                                break;
                            case 6:
                                lodgingCost = ROME_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = ROME;
                                break;
                            case 7:
                                lodgingCost = AMSTERDAM_COST * totalParticipants;
                                lodgingCostTitleValueLabel.Text = lodgingCost.ToString("c");
                                totalBookingCost += lodgingCost;
                                currentLocation = AMSTERDAM;
                                break;

                            default:
                                break;
                        }

                        summaryTotalRegistrationFees += registrationCost;
                        summaryTotalLodgingFees += lodgingCost;

                        this.enableWorkshopSelectionGroupBox(false);
                        this.enableLocationSelectionGroupBox(false);
                        this.enablePrintCertificateSectionPanel(false);
                        this.enableParticipantsCountSectionPanel(false);
                        this.enableSuiteSelectionSectionGroupBox(false);

                        this.showBookingDetailsSectionPanel(true);
                        bookFunctionButton.Visible = true;
                        clearFunctionButton.Enabled = false;
                        summaryFunctionButton.Enabled = false;
                    }
                    else
                    {
                        this.showErrorDialogBox("Location");
                    }
                }
                else
                {
                    this.showErrorDialogBox("Workshop");
                }
            }
            else
            {
                this.showErrorDialogBox("valid input");
            }



            if (printCertficateCheckBox.Checked == true)
            {
                certificateCost = CERTIFICATE_COST * totalParticipants;
                certificateCostTitleValueLabel.Text = certificateCost.ToString("c");
                totalBookingCost += certificateCost;
                summaryTotalCertificateAmount += certificateCost;
            }
            else {
                certificateCostTitleValueLabel.Text = 0.ToString("c");
            }

            if (masterSuiteRadioButton.Checked)
            {
                roomUpgradeCostTitleValueLabel.Text = MASTER_SUITE_COST.ToString("c");
                totalBookingCost += MASTER_SUITE_COST;
                summaryTotalRoomUpgradesAmount += MASTER_SUITE_COST;
            }
            else if (juniorSuiteRadioButton.Checked)
            {
                roomUpgradeCostTitleValueLabel.Text = JUNIOR_SUITE_COST.ToString("c");
                totalBookingCost += JUNIOR_SUITE_COST;
                summaryTotalRoomUpgradesAmount += JUNIOR_SUITE_COST;
            }
            else {
                roomUpgradeCostTitleValueLabel.Text = 0.ToString("c");
            }

            if (totalParticipants > 4 && (masterSuiteRadioButton.Checked || juniorSuiteRadioButton.Checked)) {
                totalBookingCost = totalBookingCost - (GROUP_DISCOUNT * totalBookingCost);
                summaryTotalDiscountedBookings++;
            }

            totalCostTitleValueLabel.Text = totalBookingCost.ToString("c");
            summaryTotalRevenueAmount += totalBookingCost;

        }

        //Event handler to reset all the form fields
        private void clearFunctionButton_Click(object sender, EventArgs e)
        {
            participantsCountTextBox.Text = "0";
            noSuiteRadioButton.Checked = true;
            printCertficateCheckBox.Checked = false;
            workshopSelectionListBox.ClearSelected();
            locationSelectionListBox.ClearSelected();
        }

        //Event handler to display the summary details of all the bookings
        private void summaryFunctionButton_Click(object sender, EventArgs e)
        {
            totalBookingsTitleValueLabel.Text = summaryTotalBookings.ToString();
            totalRegistrationsTitleValueLabel.Text = summaryTotalRegistrationFees.ToString("c");
            totalLodgingTitleValueLabel.Text = summaryTotalLodgingFees.ToString("c");
            totalDiscountedBookingsTitleValueLabel.Text = summaryTotalDiscountedBookings.ToString();
            totalCertificatesIssuedTitleValueLabel.Text = summaryTotalCertificateAmount.ToString("c");
            totalValueRoomUpgradesTitleValueLabel.Text = summaryTotalRoomUpgradesAmount.ToString("c");
            avgRevenueTitleValueLabel.Text = (summaryTotalRevenueAmount / summaryTotalBookings).ToString("c");

            this.showSummaryDetailsSectionPanel(true);
            this.enableWorkshopSelectionGroupBox(false);
            this.enableLocationSelectionGroupBox(false);
            this.enablePrintCertificateSectionPanel(false);
            this.enableParticipantsCountSectionPanel(false);
            this.enableSuiteSelectionSectionGroupBox(false);
            displayFunctionButton.Enabled = false;
            clearFunctionButton.Visible = false;
            backFunctionButton.Visible = true;
        }

        //Event handler to confirm and update the booking selections made on the application
        private void bookFunctionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Workshop Name:   " + workshopTitleValueLabel.Text + "\n" +
                "Location Name:       " + currentLocation + "\n" +
                "Total Cost:               " + totalCostTitleValueLabel.Text + "\n", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            summaryTotalBookings += 1;
            this.resetForm();
        }

        //Event handler to close the form application
        private void exitFunctionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to show the error dialog when an invalid input value is given
        private void showErrorDialogBox(string item)
        {
            MessageBox.Show("Please select a " + item + " to proceed.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Method to toggle the visibility of Workshop Selection Section
        private void enableWorkshopSelectionGroupBox(bool value)
        {
            workshopSelectionSectionGroupBox.Enabled = value;
        }

        //Method to toggle the visibility of Location Selection Section
        private void enableLocationSelectionGroupBox(bool value)
        {
            locationSelectionSectionGroupBox.Enabled = value;
        }

        //Method to toggle the visibility of Print Certificate Selection Section
        private void enablePrintCertificateSectionPanel(bool value)
        {
            printCertificateSectionPanel.Enabled = value;
        }

        //Method to toggle the visibility of Participants Count Section
        private void enableParticipantsCountSectionPanel(bool value)
        {
            participantsCountSectionPanel.Enabled = value;
        }

        //Method to toggle the visibility of Suite Selection Section
        private void enableSuiteSelectionSectionGroupBox(bool value)
        {
            suiteSelectionSectionGroupBox.Enabled = value;
        }

        //Method to toggle the visibility of Booking Details Section
        private void showBookingDetailsSectionPanel(bool value)
        {
            bookingDetailsSectionPanel.Visible = value;
        }

        //Method to toggle the visibility of Summary Details Section
        private void showSummaryDetailsSectionPanel(bool value)
        {
            bookingSummaryDetailsSectionPanel.Visible = value;
        }

        //Method to reset all the form fields to inital values
        private void resetForm() {
            participantsCountTextBox.Text = "0";
            noSuiteRadioButton.Checked = true;
            printCertficateCheckBox.Checked = false;
            workshopSelectionListBox.ClearSelected();
            locationSelectionListBox.ClearSelected();

            this.showBookingDetailsSectionPanel(false);
            this.enableWorkshopSelectionGroupBox(true);
            this.enableLocationSelectionGroupBox(true);
            this.enablePrintCertificateSectionPanel(true);
            this.enableParticipantsCountSectionPanel(true);
            this.enableSuiteSelectionSectionGroupBox(true);
            this.showSummaryDetailsSectionPanel(false);

            clearFunctionButton.Enabled = true;
            clearFunctionButton.Visible = true;
            summaryFunctionButton.Enabled = true;
            displayFunctionButton.Enabled = true;

            bookFunctionButton.Visible = false;
            displayFunctionButton.Visible = true;
            backFunctionButton.Visible = false;
        }

        //Method to go back to the main screen from the Summary screen
        private void backFunctionButton_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }
    }
}
