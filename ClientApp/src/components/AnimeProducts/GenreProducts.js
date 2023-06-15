import React, { useEffect, useState } from 'react';
import axios from 'axios';

function GenreProducts({ genre }) {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const response = await axios.get(`http://localhost:5000/api/products/genre/${genre}`);
        setProducts(response.data);
      } catch (error) {
        console.error('Failed to fetch products:', error);
      }
    };

    fetchProducts();
  }, [genre]);

  return (
    <div>
      <h1>{genre} Products</h1>
      
      
    </div>
  );
}

export default GenreProducts;
