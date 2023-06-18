import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { getToken } from '../helpers/auth';

const ProfilePage = () => {
  const [user, setUser] = useState(null);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetchProfile();
  }, []);

  const fetchProfile = async () => {
    try {
      const token = getToken();
      console.log('Token:', token);

      if (!token) {
        setError('No authentication token found.');
        return;
      }

      const config = {
        headers: { Authorization: `Bearer ${token}` }
      };
      console.log('Config:', config);

      const response = await axios.get('http://localhost:5000/api/account/profile', config);
      console.log('Response:', response);

      setUser(response.data);
    } catch (err) {
      console.error('Error:', err);
      setError('Error occurred while fetching profile');
    }
  };

  if (error) {
    return <div>Error: {error}</div>;
  }

  if (!user) {
    return <div>Loading...</div>;
  }

  return (
    <div>
      <h1>Profile</h1>
      <p>Email: {user.email}</p>
      <p>First Name: {user.firstName}</p>
      <p>Last Name: {user.lastName}</p>
      {/* add more fields as needed */}
    </div>
  );
};

export default ProfilePage;
