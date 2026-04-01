package sConboyLab7;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;
import javax.swing.border.EmptyBorder;

public class BankFrame extends JFrame implements ActionListener
{
    // one active account at a time
    private BankAccount currentAccount;

    // top sectionononon
    JLabel headerLabel = new JLabel("Bank App");
    JLabel accountInfoLabel = new JLabel("Enter user information");

    JLabel accountNumberLabel = new JLabel("Account Number");
    JTextField accountNumberTextbox = new JTextField(25);

    JLabel nameLabel = new JLabel("Name");
    JTextField nameTextbox = new JTextField(25);

    JLabel emailLabel = new JLabel("Email");
    JTextField emailTextbox = new JTextField(25);

    JLabel phoneNumberLabel = new JLabel("Phone Number");
    JTextField phoneNumberTextbox = new JTextField(25);

    JLabel startingBalanceLabel = new JLabel("Starting Balance");
    JTextField startingBalanceTextbox = new JTextField(25);

    JLabel accountSelectionLabel = new JLabel("Select an account type");
    String[] accountTypes = {"Default", "Checking", "Savings", "Crypto", "Mutual Fund"};
    JComboBox<String> accountCombobox = new JComboBox<>(accountTypes);

    JButton createButton = new JButton("Create");

    // account type additions
    JPanel extraFieldsPanel = new JPanel(new GridLayout(0, 2, 10, 10));

    // Checking
    JLabel overdraftLimitLabel = new JLabel("Overdraft Limit");
    JTextField overdraftLimitTextbox = new JTextField(25);

    // Savings
    JLabel interestRateLabel = new JLabel("Interest Rate");
    JTextField interestRateTextbox = new JTextField(25);

    // Crypto
    JLabel cryptoBalanceLabel = new JLabel("Crypto Balance");
    JTextField cryptoBalanceTextbox = new JTextField(25);

    JLabel cryptoTypeLabel = new JLabel("Crypto Type");
    JTextField cryptoTypeTextbox = new JTextField(25);

    // Mutual Fund
    JLabel investmentBalanceLabel = new JLabel("Investment Balance");
    JTextField investmentBalanceTextbox = new JTextField(25);

    JLabel riskLevelLabel = new JLabel("Risk Level");
    JTextField riskLevelTextbox = new JTextField(25);

   // active panel declarations
    JPanel accountPanel = new JPanel();

    JLabel activeTypeLabel = new JLabel("Type: ");
    JLabel activeAccountNumLabel = new JLabel("Account #: ");
    JLabel activeNameLabel = new JLabel("Name: ");
    JLabel activeEmailLabel = new JLabel("Email: ");
    JLabel activePhoneLabel = new JLabel("Phone: ");
    JLabel activeBalanceLabel = new JLabel("Balance: ");
    JLabel accountSpecificDetailsLabel = new JLabel("Details: ");

    JLabel depositLabel = new JLabel("Deposit Amount");
    JTextField depositTextbox = new JTextField(10);
    JButton depositButton = new JButton("Deposit");

    JLabel withdrawLabel = new JLabel("Withdraw Amount");
    JTextField withdrawTextbox = new JTextField(10);
    JButton withdrawButton = new JButton("Withdraw");

    public BankFrame()
    {
        super("Bank App");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new BorderLayout(10, 10));

        // add user data here
        JPanel formPanel = new JPanel();
        formPanel.setLayout(new BoxLayout(formPanel, BoxLayout.Y_AXIS));
        formPanel.setBorder(new EmptyBorder(15, 15, 15, 15));

        JPanel headerPanel = new JPanel(new FlowLayout(FlowLayout.CENTER));
        headerPanel.add(headerLabel);

        JPanel infoPanel = new JPanel(new FlowLayout(FlowLayout.CENTER));
        infoPanel.add(accountInfoLabel);

        JPanel accountNumberPanel = new JPanel(new GridLayout(1, 2, 10, 10));
        accountNumberPanel.add(accountNumberLabel);
        accountNumberPanel.add(accountNumberTextbox);

        JPanel namePanel = new JPanel(new GridLayout(1, 2, 10, 10));
        namePanel.add(nameLabel);
        namePanel.add(nameTextbox);

        JPanel emailPanel = new JPanel(new GridLayout(1, 2, 10, 10));
        emailPanel.add(emailLabel);
        emailPanel.add(emailTextbox);

        JPanel phoneNumberPanel = new JPanel(new GridLayout(1, 2, 10, 10));
        phoneNumberPanel.add(phoneNumberLabel);
        phoneNumberPanel.add(phoneNumberTextbox);

        JPanel startingBalancePanel = new JPanel(new GridLayout(1, 2, 10, 10));
        startingBalancePanel.add(startingBalanceLabel);
        startingBalancePanel.add(startingBalanceTextbox);

        JPanel accountTypePanel = new JPanel(new GridLayout(1, 2, 10, 10));
        accountTypePanel.add(accountSelectionLabel);
        accountTypePanel.add(accountCombobox);

        extraFieldsPanel.setBorder(BorderFactory.createTitledBorder("Account Type Details"));

        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.CENTER));
        buttonPanel.add(createButton);

        // alignment stuff
        headerPanel.setAlignmentX(LEFT_ALIGNMENT);
        infoPanel.setAlignmentX(LEFT_ALIGNMENT);
        accountNumberPanel.setAlignmentX(LEFT_ALIGNMENT);
        namePanel.setAlignmentX(LEFT_ALIGNMENT);
        emailPanel.setAlignmentX(LEFT_ALIGNMENT);
        phoneNumberPanel.setAlignmentX(LEFT_ALIGNMENT);
        startingBalancePanel.setAlignmentX(LEFT_ALIGNMENT);
        accountTypePanel.setAlignmentX(LEFT_ALIGNMENT);
        extraFieldsPanel.setAlignmentX(LEFT_ALIGNMENT);
        buttonPanel.setAlignmentX(LEFT_ALIGNMENT);

        // keep normal rows from doing dumb expansions
        headerPanel.setMaximumSize(headerPanel.getPreferredSize());
        infoPanel.setMaximumSize(infoPanel.getPreferredSize());
        accountNumberPanel.setMaximumSize(accountNumberPanel.getPreferredSize());
        namePanel.setMaximumSize(namePanel.getPreferredSize());
        emailPanel.setMaximumSize(emailPanel.getPreferredSize());
        phoneNumberPanel.setMaximumSize(phoneNumberPanel.getPreferredSize());
        startingBalancePanel.setMaximumSize(startingBalancePanel.getPreferredSize());
        accountTypePanel.setMaximumSize(accountTypePanel.getPreferredSize());
        buttonPanel.setMaximumSize(buttonPanel.getPreferredSize());

        // add all the user input section stuff
        formPanel.add(headerPanel);
        formPanel.add(Box.createVerticalStrut(5));
        formPanel.add(infoPanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(accountNumberPanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(namePanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(emailPanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(phoneNumberPanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(startingBalancePanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(accountTypePanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(extraFieldsPanel);
        formPanel.add(Box.createVerticalStrut(10));
        formPanel.add(buttonPanel);

        // account panel stuff
        accountPanel.setLayout(new GridLayout(0, 2, 10, 10));
        accountPanel.setBorder(BorderFactory.createTitledBorder("Active Account"));
        accountPanel.setVisible(false);

        accountPanel.add(activeTypeLabel);
        accountPanel.add(new JLabel(""));

        accountPanel.add(activeAccountNumLabel);
        accountPanel.add(activeNameLabel);

        accountPanel.add(activeEmailLabel);
        accountPanel.add(activePhoneLabel);

        accountPanel.add(activeBalanceLabel);
        accountPanel.add(new JLabel(""));

        accountPanel.add(accountSpecificDetailsLabel);
        accountPanel.add(new JLabel(""));

        accountPanel.add(depositLabel);
        accountPanel.add(depositTextbox);
        accountPanel.add(new JLabel(""));
        accountPanel.add(depositButton);

        accountPanel.add(withdrawLabel);
        accountPanel.add(withdrawTextbox);
        accountPanel.add(new JLabel(""));
        accountPanel.add(withdrawButton);

        // listeners
        accountCombobox.addActionListener(this);
        createButton.addActionListener(this);
        depositButton.addActionListener(this);
        withdrawButton.addActionListener(this);

        // add them thangs in
        updateExtraFieldsPanel();

        add(formPanel, BorderLayout.NORTH);
        add(accountPanel, BorderLayout.CENTER);

        setLocationRelativeTo(null);
        pack();
        setVisible(true);
    }
    
    // actual methods _________________________________________________________

    @Override
    public void actionPerformed(ActionEvent e)
    {
        Object source = e.getSource();

        if (source == accountCombobox)
        {
            updateExtraFieldsPanel();
        }
        else if (source == createButton)
        {
            createAccount();
        }
        else if (source == depositButton)
        {
            depositToCurrentAccount();
        }
        else if (source == withdrawButton)
        {
            withdrawFromCurrentAccount();
        }
    }

    private void updateExtraFieldsPanel()
    {
        extraFieldsPanel.removeAll();

        String selectedType = (String) accountCombobox.getSelectedItem();

        if (selectedType.equals("Checking"))
        {
            extraFieldsPanel.add(overdraftLimitLabel);
            extraFieldsPanel.add(overdraftLimitTextbox);
        }
        else if (selectedType.equals("Savings"))
        {
            extraFieldsPanel.add(interestRateLabel);
            extraFieldsPanel.add(interestRateTextbox);
        }
        else if (selectedType.equals("Crypto"))
        {
            extraFieldsPanel.add(cryptoBalanceLabel);
            extraFieldsPanel.add(cryptoBalanceTextbox);
            extraFieldsPanel.add(cryptoTypeLabel);
            extraFieldsPanel.add(cryptoTypeTextbox);
        }
        else if (selectedType.equals("Mutual Fund"))
        {
            extraFieldsPanel.add(investmentBalanceLabel);
            extraFieldsPanel.add(investmentBalanceTextbox);
            extraFieldsPanel.add(riskLevelLabel);
            extraFieldsPanel.add(riskLevelTextbox);
        }

        extraFieldsPanel.setMaximumSize(extraFieldsPanel.getPreferredSize());
        extraFieldsPanel.revalidate();
        extraFieldsPanel.repaint();
        pack();
    }

    private void createAccount()
    {
        try
        {
            String accountNum = accountNumberTextbox.getText().trim();
            String name = nameTextbox.getText().trim();
            String email = emailTextbox.getText().trim();
            String phoneNum = phoneNumberTextbox.getText().trim();
            double startingBalance = Double.parseDouble(startingBalanceTextbox.getText().trim());

            String selectedType = (String) accountCombobox.getSelectedItem();

            if (selectedType.equals("Default"))
            {
                currentAccount = new BankAccount(accountNum, name, email, phoneNum, startingBalance);
            }
            else if (selectedType.equals("Checking"))
            {
                double overdraftLimit = Double.parseDouble(overdraftLimitTextbox.getText().trim());

                currentAccount = new CheckingAccount(
                    accountNum, name, email, phoneNum, startingBalance, overdraftLimit
                );
            }
            else if (selectedType.equals("Savings"))
            {
                double interestRate = Double.parseDouble(interestRateTextbox.getText().trim());

                currentAccount = new SavingsAccount(
                    accountNum, name, email, phoneNum, startingBalance, interestRate
                );
            }
            else if (selectedType.equals("Crypto"))
            {
                double cryptoBalance = Double.parseDouble(cryptoBalanceTextbox.getText().trim());
                String cryptoType = cryptoTypeTextbox.getText().trim();

                currentAccount = new CryptoAccount(
                    accountNum, name, email, phoneNum, startingBalance, cryptoBalance, cryptoType
                );
            }
            else if (selectedType.equals("Mutual Fund"))
            {
                double investmentBalance = Double.parseDouble(investmentBalanceTextbox.getText().trim());
                String riskLevel = riskLevelTextbox.getText().trim();

                currentAccount = new MutualFund(
                    accountNum, name, email, phoneNum, startingBalance, investmentBalance, riskLevel
                );
            }
            else
            {
                currentAccount = new BankAccount(accountNum, name, email, phoneNum, startingBalance);
            }

            updateAccountPanel();
            accountPanel.setVisible(true);
            pack();
        }
        catch (NumberFormatException ex)
        {
            JOptionPane.showMessageDialog(this, "Please enter valid numeric values.");
        }
    }

    private void depositToCurrentAccount()
    {
        if (currentAccount == null)
        {
            JOptionPane.showMessageDialog(this, "Please create an account first.");
            return;
        }

        try
        {
            double amount = Double.parseDouble(depositTextbox.getText().trim());
            currentAccount.deposit(amount);
            updateAccountPanel();
            depositTextbox.setText("");
        }
        catch (NumberFormatException ex)
        {
            JOptionPane.showMessageDialog(this, "Please enter a valid deposit amount.");
        }
    }

    private void withdrawFromCurrentAccount()
    {
        if (currentAccount == null)
        {
            JOptionPane.showMessageDialog(this, "Please create an account first.");
            return;
        }

        try
        {
            double amount = Double.parseDouble(withdrawTextbox.getText().trim());
            currentAccount.withdraw(amount);
            updateAccountPanel();
            withdrawTextbox.setText("");
        }
        catch (NumberFormatException ex)
        {
            JOptionPane.showMessageDialog(this, "Please enter a valid withdrawal amount.");
        }
    }

    private void updateAccountPanel()
    {
        activeTypeLabel.setText("Type: " + currentAccount.getClass().getSimpleName());
        activeAccountNumLabel.setText("Account Number: " + currentAccount.getAcctNum());
        activeNameLabel.setText("Name: " + currentAccount.getName());
        activeEmailLabel.setText("Email: " + currentAccount.getEmail());
        activePhoneLabel.setText("Phone: " + currentAccount.getPhoneNum());
        activeBalanceLabel.setText("Balance: " + currentAccount.getBalance());

        if (currentAccount instanceof CheckingAccount)
        {
            CheckingAccount acc = (CheckingAccount) currentAccount;
            accountSpecificDetailsLabel.setText("Details: Overdraft Limit : " + acc.getOverdraftLimit());
        }
        else if (currentAccount instanceof SavingsAccount)
        {
            SavingsAccount acc = (SavingsAccount) currentAccount;
            accountSpecificDetailsLabel.setText("Details: Interest Rate : " + acc.getInterestRate());
        }
        else if (currentAccount instanceof CryptoAccount)
        {
            CryptoAccount acc = (CryptoAccount) currentAccount;
            accountSpecificDetailsLabel.setText(
                "Details: Crypto Balance : " + acc.getCryptoBalance() + ", Crypto Type : " + acc.getCryptoType()
            );
        }
        else if (currentAccount instanceof MutualFund)
        {
            MutualFund acc = (MutualFund) currentAccount;
            accountSpecificDetailsLabel.setText(
                "Details: Investment Balance : " + acc.getInvestmentBalance() + ", Risk Level : " + acc.getRiskLevel()
            );
        }
        else
        {
            accountSpecificDetailsLabel.setText("Details: Standard account");
        }
    }
}