
/**
 * Damen.java
 *
 * @author Jannis Guhl
 * @version 1.0 Finds solutions to the n-dames-problem
 */
public class Damen
{
    private static int solutions = 0;

    /**
     * Testet, ob eine der Damen eine andere schlagen kann.
     *
     * @param board die aktuelle Belegung des Schachbretts (inklusive der zu
     * testenden Belegung in Spalte column)
     * @param column die Spalte, deren Belegung getestet werden muss
     * @return true wenn die Dame in Spalte column durch eine der Damen in den
     * Spalten 0 to column-1 angegriffen wird
     */
    public static boolean isAttacked(int[] board, int column)
    {
        // Teste als Erstes, ob eine Dame in derselben Zeile steht
        for (int i = 0; i < column; i++)
        {
            if (board[i] == board[column])
            {
                return true;
            }
        }

        // Teste nun, ob in der oberen Diagonale eine Dame steht
        for (int i = column - 1, j = board[column] - 1; i >= 0; i--, j--)
        {
            if (board[i] == j)
            {
                return true;
            }
        }

        // Teste, ob in der unteren Diagonale eine Dame steht
        for (int i = column - 1, j = board[column] + 1; i >= 0; i--, j++)
        {
            if (board[i] == j)
            {
                return true;
            }
        }

        // Wenn das Programm hier angekommen ist, steht die Dame "frei"
        return false;
    }

    /**
     * Sucht rekursiv eine Loesung des Problems. Wenn diese gefunden wurde, dann
     * wird die Loesung auf der Standardausgabe ausgegeben.
     *
     * @param board die aktuelle Belegung des Schachbretts (inklusive der zu
     * testenden Belegung in Spalte column)
     * @param column die Spalte, deren Belegung gesetzt werden muss
     * @return true wenn eine Belegung fuer die Spalte column gefunden wurde
     *
     */
    public static boolean setQueen(int[] board, int column)
    {
        // Sind wir fertig?
        if (column == board.length)
        {
            printSolution(board);
            System.out.println();
            solutions++;
            return false;
        }

        // Suche die richtige Position fuer die neue Dame
        for (int i = 0; i < board.length; i++)
        {
            board[column] = i;         // Probiere jede Stelle aus
            if (isAttacked(board, column)) // Falls die Dame nicht frei steht
            {
                continue; // versuche es an der naechsten Stelle
            }
            boolean success = // moeglicher Kandidat gefunden? --
                    setQueen(board, column + 1);   // teste die folgenden Spalten
            if (success)               // falls es geklappt hat
            {
                return true;
            }
        }

        // Wenn das Programm hier angekommen ist,
        // stecken wir in einer Sackgasse
        return false;
    }

    /**
     * Gibt das Schachbrett auf dem Bildschirm aus.
     *
     * @param board die zu druckende Belegung des Schachbretts
     */
    public static void printSolution(int[] board)
    {
        for (int i = 0; i < board.length; i++)
        {      // Anzahl der Zeilen
            for (int j = 0; j < board.length; j++)      // Anzahl der Spalten
            {
                System.out.print("|" + ((i == board[j]) ? 'D' : ' '));
            }
            System.out.println("|");       // Zeilenende
        }
    }

    /**
     * Initialisiert das Schachbrett und ruft die Methode "setQueen" auf
     * @param args 0 - Brettgroesse
     */
    public static void main(String[] args)
    {
        try
        {
            int n = Integer.parseInt(args[0]);
            int i;

            int[] board = new int[n]; // Initialisiere das Spielfeld
            for (i = 0; i < n; i++)
            {
                board[i] = -1;
            }

            setQueen(board, 0); // Starte die Suche in der linken oberen Ecke
            System.out.println("Es gibt fuer " + n + " Damen, " + solutions + " Loesungen.");
        }
        catch (Exception e)
        {
            System.out.println("Es wurde kein Parameter uebergeben!");
        }
    }

}
