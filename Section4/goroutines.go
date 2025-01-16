package main

//import packages
import (
    "fmt" 
    "sync"
    "time"
)

// Function that prints numbers starting from 'start' up to 'start + 5'
func printNumbers(wg *sync.WaitGroup, start int) {
    for i := start; i < start+5; i++ {
        fmt.Println(i)
        time.Sleep(100 * time.Millisecond) // Simulate work
    }
    wg.Done() // Signal that this goroutine has finished executing
}

func main() {
    var wg sync.WaitGroup
    
    wg.Add(2) // Indicate that we will wait for two goroutines 
    
    go printNumbers(&wg, 1) // Start first goroutine printing numbers from 1-5 
    go printNumbers(&wg, 6) // Start second goroutine printing numbers from 6-10 

    fmt.Println("Main function is waiting for goroutines to finish...")
    
    wg.Wait() // Wait for both goroutines to finish before exiting main function 
    
    fmt.Println("All goroutines have completed.")
}