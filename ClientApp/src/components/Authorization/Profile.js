import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { getId, getPayLoad } from '../../components/helpers/auth';

function Profile() {
    const [user, setUser] = useState(null);

    useEffect(() => {
        const fetchProfile = async () => {
            const token = getPayLoad(); // Assuming getPayLoad() retrieves the JWT payload

            try {
                const response = await axios.get('http://localhost:5000/api/account/profile/', {
                    headers: {
                        Authorization: `Bearer ${token}`
                    }
                });

                setUser(response.data);
            } catch (error) {
                console.error('Failed to fetch user profile:', error);
            }
        };

        fetchProfile();
    }, []);

    if (!user) {
        return 'Loading...';
    }

    return (
        <div>
            <h1>{user.name}'s Profile</h1>
            <p>Email: {user.email}</p>
            {/* Add more fields as necessary */}
        </div>
    );
}

export default Profile;
