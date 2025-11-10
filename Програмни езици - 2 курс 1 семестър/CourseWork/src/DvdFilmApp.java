import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.util.ArrayList;
import java.util.Optional;

public class DvdFilmApp extends JFrame {

    static class DvdFilm {
        private final String inventoryNumber;
        private final String title;
        private final String director;
        private final String genre;
        private final int year;

        public DvdFilm(String inventoryNumber, String title, String director, String genre, int year) {
            this.inventoryNumber = inventoryNumber;
            this.title = title;
            this.director = director;
            this.genre = genre;
            this.year = year;
        }

        public String getInventoryNumber() { return inventoryNumber; }

        public String toLine() {
            // Едноредов текст за извеждане в текстово поле
            return String.format("№%s | „%s“ | %s | %s | %d",
                    inventoryNumber, title, director, genre, year);
        }
    }

    // Съхранение (колекция вместо масив за удобство)
    private final java.util.List<DvdFilm> films = new ArrayList<>();

    // Компоненти
    private JTextField tfInv;
    private JTextField tfTitle;
    private JTextField tfDirector;
    private JComboBox<String> cbGenre;
    private JTextField tfYear;
    private JTextField tfResult;

    public DvdFilmApp() {
        super("Справки за DVD филми — Програмни езици (Swing)");

        // Основен панел
        JPanel root = new JPanel(new BorderLayout(12, 12));
        root.setBorder(new EmptyBorder(12, 12, 12, 12));
        setContentPane(root);

        // Форма (лява част)
        JPanel form = new JPanel(new GridBagLayout());
        root.add(form, BorderLayout.CENTER);
        GridBagConstraints gc = new GridBagConstraints();
        gc.insets = new Insets(6, 6, 6, 6);
        gc.fill = GridBagConstraints.HORIZONTAL;
        gc.weightx = 1.0;

        // Етикети
        JLabel lbInv = new JLabel("Инвентарен № (ключ):");
        lbInv.setFont(lbInv.getFont().deriveFont(Font.BOLD)); // bold според условието

        JLabel lbTitle = new JLabel("Заглавие:");
        JLabel lbDirector = new JLabel("Режисьор:");

        JLabel lbGenre = new JLabel("Жанр:");
        lbGenre.setFont(lbGenre.getFont().deriveFont(Font.ITALIC)); // italic — избира се от ComboBox

        JLabel lbYear = new JLabel("Година на излизане:");

        // Полета
        tfInv = new JTextField();
        tfTitle = new JTextField();
        tfDirector = new JTextField();

        cbGenre = new JComboBox<>(new String[]{
                "Екшън", "Приключенски", "Анимация", "Комедия",
                "Криминален", "Драма", "Фентъзи", "Исторически",
                "Ужаси", "Мистерия", "Романтичен", "Sci-Fi", "Трилър", "Уестърн"
        });
        cbGenre.setSelectedItem("Драма");

        tfYear = new JTextField();

        // Редове във формата
        int row = 0;
        addRow(form, gc, row++, lbInv, tfInv);
        addRow(form, gc, row++, lbTitle, tfTitle);
        addRow(form, gc, row++, lbDirector, tfDirector);
        addRow(form, gc, row++, lbGenre, cbGenre);
        addRow(form, gc, row++, lbYear, tfYear);

        // Бутони
        JPanel buttons = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 0));
        JButton btAdd = new JButton("Добави");
        JButton btSearch = new JButton("Справка по №");
        JButton btClear = new JButton("Изчисти");
        buttons.add(btAdd);
        buttons.add(btSearch);
        buttons.add(btClear);

        gc.gridx = 0; gc.gridy = row; gc.gridwidth = 2;
        form.add(buttons, gc);

        // Поле за резултат (едноредово според условието)
        tfResult = new JTextField();
        tfResult.setEditable(false);
        tfResult.setToolTipText("Резултат от справката ще се изпише тук");
        
        // 🔹 Нов панел с етикет "Последен резултат"
        JPanel resultPanel = new JPanel(new BorderLayout(6, 6));
        JLabel lbResult = new JLabel("Последен резултат:");
        resultPanel.add(lbResult, BorderLayout.WEST);
        resultPanel.add(tfResult, BorderLayout.CENTER);
        root.add(resultPanel, BorderLayout.SOUTH);

        // Действия
        btAdd.addActionListener(this::onAdd);
        btSearch.addActionListener(this::onSearch);
        btClear.addActionListener(e -> clearForm());

        // Настройки на прозореца
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(720, 360);
        setLocationRelativeTo(null); // центриране
    }

    private static void addRow(JPanel panel, GridBagConstraints gc, int row, JComponent label, JComponent field) {
        gc.gridx = 0; gc.gridy = row; gc.gridwidth = 1; gc.weightx = 0.0;
        panel.add(label, gc);
        gc.gridx = 1; gc.gridy = row; gc.gridwidth = 1; gc.weightx = 1.0;
        panel.add(field, gc);
    }

    // Добавяне на запис
    private void onAdd(ActionEvent e) {
        String inv = tfInv.getText().trim();
        String title = tfTitle.getText().trim();
        String director = tfDirector.getText().trim();
        String genre = (String) cbGenre.getSelectedItem();
        String yearStr = tfYear.getText().trim();

        // Валидации
        if (inv.isEmpty() || title.isEmpty() || director.isEmpty() || yearStr.isEmpty()) {
            JOptionPane.showMessageDialog(this, "Моля, попълнете всички полета.",
                    "Липсващи данни", JOptionPane.WARNING_MESSAGE);
            return;
        }
        int year;
        try {
            year = Integer.parseInt(yearStr);
            if (year < 1888 || year > 2100) throw new NumberFormatException("Невалидна година");
        } catch (NumberFormatException ex) {
            JOptionPane.showMessageDialog(this, "Годината трябва да е валидно цяло число (напр. 1999).",
                    "Грешка в година", JOptionPane.ERROR_MESSAGE);
            return;
        }

        // Проверка за дублиране на ключа
        boolean exists = films.stream().anyMatch(f -> f.getInventoryNumber().equalsIgnoreCase(inv));
        if (exists) {
            JOptionPane.showMessageDialog(this, "Вече има запис с този Инвентарен №.",
                    "Дублиран ключ", JOptionPane.ERROR_MESSAGE);
            return;
        }

        DvdFilm film = new DvdFilm(inv, title, director, genre, year);
        films.add(film);
        tfResult.setText("Добавен: " + film.toLine());
        clearInputsExceptResult();
    }

    // Справка по ключ (Инвентарен №)
    private void onSearch(ActionEvent e) {
        String inv = tfInv.getText().trim();
        if (inv.isEmpty()) {
            JOptionPane.showMessageDialog(this, "Въведете Инвентарен № за справка.",
                    "Липсва ключ", JOptionPane.INFORMATION_MESSAGE);
            return;
        }
        Optional<DvdFilm> found = films.stream()
                .filter(f -> f.getInventoryNumber().equalsIgnoreCase(inv))
                .findFirst();

        if (found.isPresent()) {
            tfResult.setText(found.get().toLine());
            // по желание — попълни формата с намерения запис
            DvdFilm f = found.get();
            tfTitle.setText(f.title);
            tfDirector.setText(f.director);
            cbGenre.setSelectedItem(f.genre);
            tfYear.setText(String.valueOf(f.year));
        } else {
            tfResult.setText("Няма запис с Инвентарен №: " + inv);
        }
    }

    private void clearForm() {
        tfInv.setText("");
        tfTitle.setText("");
        tfDirector.setText("");
        cbGenre.setSelectedIndex(0);
        tfYear.setText("");
        tfResult.setText("");
        tfInv.requestFocus();
    }

    private void clearInputsExceptResult() {
        tfInv.setText("");
        tfTitle.setText("");
        tfDirector.setText("");
        cbGenre.setSelectedIndex(0);
        tfYear.setText("");
        tfInv.requestFocus();
    }

    public static void main(String[] args) {
        // Опитай системен L&F за по-нативен вид
        try {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        } catch (Exception ignored) { }
        SwingUtilities.invokeLater(() -> new DvdFilmApp().setVisible(true));
    }
}
