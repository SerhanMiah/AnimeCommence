import React, { useState } from 'react';
import axios from 'axios';
import { Container, Row, Col, Form, Button } from 'react-bootstrap';
import { setToken, setId } from '../helpers/auth';
import '../../Style/Login.css'
import { useNavigate } from 'react-router-dom';

const Login = () => {
    const navigate = useNavigate()
    const [user, setUser] = useState({Email: '', Password: ''});

    const handleChange = e => {
        setUser({...user, [e.target.name]: e.target.value });
    }

    const login = async () => {
        try {
            const response = await axios.post('http://localhost:5000/api/account/login', user);
            console.log('Login response data:', response.data);  // Log the response data
            const token = response.data.token;  // Extract the token
            console.log('Token:', token); // check the Token
            setToken(token);
            // handle success
            console.log('login successful', response);
            navigate('/');
        } catch (error) {
            // handle error
            console.log(error);
        };
    };
    

    return (
        <Container>
            <Row className="justify-content-md-center">
                <Col xs={12} md={6}>
                    <h1 className='text-center'>Login</h1>
                    <Form>
                        <Form.Group controlId="formEmail">
                            <Form.Label>Email address</Form.Label>
                            <Form.Control type="email" name="Email" placeholder="Enter email" onChange={handleChange} />
                        </Form.Group>

                        <Form.Group controlId="formPassword">
                            <Form.Label>Password</Form.Label>
                            <Form.Control type="password" name="Password" placeholder="Password" onChange={handleChange} />
                        </Form.Group>
                        <Button variant="primary" type="button" onClick={login} className='w-100'>
                            Login
                        </Button>
                    </Form>
                </Col>
            </Row>
        </Container>
    );
}

export default Login;
