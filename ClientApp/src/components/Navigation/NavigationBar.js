import React, { useState, useEffect } from 'react';
import { Navbar, Nav, NavDropdown, Form, FormControl, Button } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import '../../Style/Navbar.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser } from '@fortawesome/free-solid-svg-icons';
import { useNavigate } from 'react-router-dom';

import { userIsAuthenticated } from '../../components/helpers/auth';


function NavigationBar() {
  const [isAuthenticated, setIsAuthenticated] = useState(userIsAuthenticated());
  const navigate = useNavigate()

  useEffect(() => {
    // This function gets called whenever the localStorage changes
    const handleStorageChange = () => {
      setIsAuthenticated(userIsAuthenticated());
    };

    // Subscribe to localStorage changes
    window.addEventListener('storage', handleStorageChange);

    // Unsubscribe when the component unmounts
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);

  // Handle Logout 
  const handleLogOut = async () => {
    try {
        window.localStorage.removeItem('local-user-Token');
        setIsAuthenticated(userIsAuthenticated());
        navigate('/');
        alert('You have been logged out');
    } catch (error) {
        console.error('Failed to log out', error);
    }
  }

  return (
    <Navbar collapseOnSelect expand="lg" bg="black" variant="dark">
      <Navbar.Brand href="#home">AnimeShop</Navbar.Brand>
      <Navbar.Toggle aria-controls="responsive-navbar-nav" />
      <Navbar.Collapse id="responsive-navbar-nav">
        <Nav className="mr-auto">
          <Nav.Link onClick={() => navigate('/products')}>All Products</Nav.Link>
          {/* Rest of your navigation items */}
          <NavDropdown title="Manga" id="collasible-nav-dropdown">
            <NavDropdown.Item href="#action/3.1">Shonen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.2">Shojo</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.3">Seinen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.4">Josei</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.5">Kodomomuke</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.6">Isekai</NavDropdown.Item>
          </NavDropdown>
          <NavDropdown title="DVD" id="collasible-nav-dropdown">
            <NavDropdown.Item href="#action/3.1">Shonen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.2">Shojo</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.3">Seinen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.4">Josei</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.5">Kodomomuke</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.6">Isekai</NavDropdown.Item>
          </NavDropdown>
          <Nav.Link href="#merchandise">Merchandise</Nav.Link>
          <Nav.Link href="#apparel">Apparel</Nav.Link>
        </Nav>
        <Form inline className="searchForm">
          <FormControl type="text" placeholder="Search" className="mr-sm-2" />
          <Button variant="outline-light">Search</Button>
        </Form>
        <Nav className="ml-auto">
          { isAuthenticated
          ? <>
            <Nav.Link as={Link} to="/profile">
              <FontAwesomeIcon icon={faUser} /> Profile
            </Nav.Link>
            <Nav.Link onClick={handleLogOut}>
              <FontAwesomeIcon icon={faUser} /> Logout
            </Nav.Link>
            <Nav.Link as={Link} to="/cart">Cart</Nav.Link>
          </>
          : <>
            <Nav.Link as={Link} to="/login">
              <FontAwesomeIcon icon={faUser} /> Login
            </Nav.Link>
            <Nav.Link as={Link} to="/register">
              <FontAwesomeIcon icon={faUser} /> Register
            </Nav.Link>
            <Nav.Link as={Link} to="/cart">Cart</Nav.Link>
          </>
          }
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default NavigationBar;
