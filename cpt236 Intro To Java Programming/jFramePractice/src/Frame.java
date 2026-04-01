import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Frame extends JFrame {

    // declarations
    private JTextArea textArea;
    private JButton button;
    private TextPanel textPanel;

    // constructor
    Frame()
    {
        super("Hello World");

        setLayout(new BorderLayout());

        textPanel = new TextPanel();
        button = new JButton("Click Me!");

        button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                textPanel.appendText("Hello\n");
            }
        });

        add(textPanel, BorderLayout.CENTER);
        add(button, BorderLayout.SOUTH);

        setSize(600,500);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
    }
}
