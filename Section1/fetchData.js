// Explicitly import fetch from node-fetch
// Requires adding "type": "module" to package.json
import fetch from 'node-fetch';

// Async function to retrieve posts from an API
async function fetchPosts() {
  try {
    // Initiate a network request to fetch posts
    const response = await fetch('https://jsonplaceholder.typicode.com/posts');

    // Convert the response to JSON format
    const data = await response.json();

    // Output the retrieved posts to the console
    console.log(data);

  } catch (error) {
    // Catch and display any errors during the fetch operation
    console.error('Error fetching data:', error);
  }
}

// Execute the fetchPosts function
fetchPosts();