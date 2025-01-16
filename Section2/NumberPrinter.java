public class NumberPrinter implements Runnable {
    public void run() { // Run
        for (int i = 1; i <= 10; i++) {
            // Print the current number
            System.out.println(i);
            try {
                Thread.sleep(1000); // Sleep for 1s
            } catch ( InterruptedException e ) {
                // Print stack trace for debugging purposes
                e.printStackTrace();
            }
        }
    }

    public static void main(String[] args) {
        Thread thread = new Thread(new NumberPrinter());
        // Start the thread

        thread.start();
    }
}
