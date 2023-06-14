import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom'
import axios from 'axios';


export default function ProductDetail() {
  const [product, setProduct] = useState([])
  const { id }= useParams();

  useEffect(() => {  
    const getData = async () => {
      try {
        const { data } = await axios.get(`http://localhost:5000/api/product/${id}`)
        console.log(data);
        setProduct(data)
      } catch (error) {
        console.log(error.message)
      }
    } 
    getData()
  }, [id])

  return (
    <div>
     <h1>Hello world</h1>
    </div>
  );
}

  
