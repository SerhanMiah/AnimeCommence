import axios from 'axios';
import { getToken } from './auth';

const axiosInstance = axios.create({
  baseURL: 'http://localhost:5000/api',
  // Add headers configuration
  headers: {
    'Authorization': `Bearer ${getToken()}`,
    'Content-Type': 'application/json'
  }
});

const getProfile = () => {
  axiosInstance.get('/account/profile')
    .then(response => {
      console.log('Profile data:', response.data);
      // Handle the response
    })
    .catch(error => {
      console.error('Error:', error);
      // Handle the error
    });
};

export default getProfile;
