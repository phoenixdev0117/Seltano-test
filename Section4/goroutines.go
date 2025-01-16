package main

import (
    "fmt"
    "sync"
    "time"
)

func printNumbers(wg *sync.WaitGroup, start int) {
    for i := start; i < start+5; i++ {
        fmt.Println(i)
        time.Sleep(100 * time.Millisecond) // Simulate work
    }
    wg.Done()
}

func main() {
    var wg sync.WaitGroup
    
    wg.Add(2)
    
    go printNumbers(&wg, 1)
    go printNumbers(&wg, 6)

    fmt.Println("Main function is waiting for goroutines to finish...")
    
    wg.Wait()
    
    fmt.Println("All goroutines have completed.")
}