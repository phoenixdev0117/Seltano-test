package main

import (
    "encoding/json" // Import package for JSON encoding and decoding
    "fmt" // Import package for formatted I/O operations
)

// Define a struct to match the JSON structure we expect to parse.
type Person struct {
    Name  string `json:"name"`
    Age   int    `json:"age"`
    Email string `json:"email"`
}

func main() {
    jsonString := `{"name": "John Doe", "age": 30, "email": "johndoe@example.com"}`
    var person Person

    err := json.Unmarshal([]byte(jsonString), &person)
    if err != nil {
        fmt.Println("Error parsing JSON:", err)
        return
    }

    fmt.Printf("Name: %s, Age: %d, Email: %s\n", person.Name, person.Age, person.Email)
}