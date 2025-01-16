function debounce(func, delay) {
    let timeoutId;
    return function (...args) {
      //Delay time
      clearTimeout(timeoutId);
      timeoutId = setTimeout(() => func(...args), delay);
    };
  }
  
  // Test the debounce function with logs
  const debouncedLog = debounce((message) => console.log(message), 1000);
  
  console.log("Starting debounce test...");
  debouncedLog("This will be logged once after 1 second");
  debouncedLog("This will replace the previous message");
  debouncedLog("This is the final message that will be logged");
  