import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Rating from 'react-rating-stars-component';
import { Card, Button } from 'react-bootstrap';
import '../../Style/Product.css'

function Products() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const { data } = await axios.get('http://localhost:5000/api/product');
        setProducts(data);
      } catch (error) {
        console.error('Error fetching data', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="d-flex flex-wrap justify-content-around">
      <h1 className="w-100 text-center mb-4">Anime Products</h1>
      {products.map((product, index) => (
        <Card key={index} style={{ width: '18rem', marginBottom: '20px' }}>
          <Card.Img variant="top" src={product.images ? product.images[0] : 'defaultImage.jpg'} />
          <Card.Body>
            <Card.Title>{product.name}</Card.Title>
            <Card.Text>
              {product.description}
              <br />
              <strong>Publisher: </strong> {product.publisher}
              <br />
              <strong>Release Date: </strong> {new Date(product.releaseDate).toLocaleDateString()}
              <br />
              <strong>Genre: </strong> {product.genre}
              <br />
              <strong>Category: </strong> {product.category}
            </Card.Text>
            <Rating
              count={5}
              size={24}
              activeColor="#ffd700"
              value={product.rating}
              edit={false}
            />
            <p><strong>Price:</strong> ${product.price}</p>
            <Button variant="primary">Add to Cart</Button>
          </Card.Body>
        </Card>
      ))}
    </div>
  );
}

export default Products;
