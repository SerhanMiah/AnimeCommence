import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { getToken } from '../helpers/auth';

const ProfilePage = () => {
  const [userProfile, setUserProfile] = useState(null);
  const [errors, setErrors] = useState(false);

  useEffect(() => {
    const fetchProfile = async () => {
      try {
        const token = getToken(); // Get the JWT token from your local storage or state
        console.log(token);
        const config = {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        };

        const response = await axios.get('http://localhost:5000/api/account/profile', config);
        setUserProfile(response.data);
      } catch (error) {
        console.error('Error:', error);
        setErrors(true);
      }
    };

    fetchProfile();
  }, []);

  return (
    <div>
      {userProfile ? (
        <>
          {/* Display the profile data */}
          <h2>{userProfile.name}</h2>
          <p>Email: {userProfile.email}</p>
          {/* Add more profile information here */}
        </>
      ) : errors ? (
        <p>Error occurred while fetching profile</p>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
};

export default ProfilePage;
