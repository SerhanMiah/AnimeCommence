import axios from 'axios';
import { Col } from 'react-bootstrap';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import '../../Style/Register.css';

const AddressForm = () => {
  const navigate = useNavigate();

  const [address, setAddress] = useState({
    Address: '',
    City: '',
    State: '',
    PostalCode: '',
    Country: ''
  });

  const [errors, setErrors] = useState(false);

  const handleChange = (event) => {
    const newObj = { ...address, [event.target.name]: event.target.value };
    setAddress(newObj);
    setErrors('');
  };

  const handleSubmit = async (event) => {
    event.preventDefault();
    try {
      const { data } = await axios.post('http://localhost:5000/api/account/address', address);
      console.log('address has been successfully added', data);
      // navigate to the next page
    } catch (error) {
      setErrors(error.message);
      console.log(error.message);
    }
  };

  // render the form with address related fields here
  // similar to your register form
};

export default AddressForm;
