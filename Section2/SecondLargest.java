public class SecondLargest {
    public static void main(String[] args) {
        int[] array = {12, 35, 1, 10, 34, 1}; // Sample array of integers
        int largest = Integer.MIN_VALUE; // Initialize largest to the smallest integer value
        int secondLargest = Integer.MIN_VALUE; // Initialize second largest similarly
        
        // Find Second Largest number in the array
        for (int num : array) {
            if (num > largest) {
                secondLargest = largest;
                largest = num;
            } else if (num > secondLargest && num < largest) {
                secondLargest = num;
            }
        }
        // Output the result
        System.out.println("The second largest number is: " + secondLargest);
    }
}