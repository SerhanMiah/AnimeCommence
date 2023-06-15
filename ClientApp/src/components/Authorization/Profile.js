import axios from 'axios';
import { useEffect, useState } from 'react';
import { getToken } from '../helpers/auth.js';
import Container from 'react-bootstrap/Container';
import { Link } from 'react-router-dom';
import { Card } from 'react-bootstrap';
  
const ProfilePage = () => {
  
  const [userProfile, setUserProfile] = useState(null);
  const [errors, setErrors] = useState(false);

  useEffect(() => {
    const getProfile = async () => {
      try {
        const token = getToken();
        console.log('Token:', token); 
        const response = await axios.get('http://localhost:5000/api/account/profile', {
          headers: {
            Authorization: `Bearer ${token}`
          }
        });
        console.log('Profile data:', response.data); 
        setUserProfile(response.data);
      } catch (error) {
        console.log('Error:', error); 
        setErrors(true);
      }
    };
  
    getProfile();
  }, []);
  
  

  return (
    <Container as="main" className="Profile-page">
      <div className="display">
        {userProfile ? (
          <div className="container">
            <div className="fb-profile">
              <Card.Img
                align="left"
                className="fb-image-profile thumbnail"
                src={userProfile.profile_image}
                alt={userProfile.username}
              />
              <div className="fb-profile-text">
                <Card.Body>
                  <Card.Title>
                    <h1>HI, {userProfile.username}</h1>
                  </Card.Title>
                  <Card.Text>
                    <h1>Welcome, {userProfile.name}</h1>
                    {userProfile.bio}
                  </Card.Text>
                  <Link to={`/profileEdit/${userProfile.id}`} className="btn btn-primary">
                    Edit Profile
                  </Link>
                </Card.Body>
              </div>
            </div>
          </div>
        ) : (
          <>
            {errors ? <h2>Oops something went wrong.</h2> : <h2>Loading...</h2>}
          </>
        )}
      </div>
    </Container>
  );
};

export default ProfilePage;
    