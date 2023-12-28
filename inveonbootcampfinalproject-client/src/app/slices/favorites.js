import { ProductData } from "../data/ProductData";
import Swal from "sweetalert2";
import { createSlice, nanoid, createAsyncThunk } from '@reduxjs/toolkit'
import HttpService from "../../services/HttpService";
import { fetchProductById } from "./product";
import userManager from "../../utils/userManager";

const initialState = {
    products: [],
    status: 'idle',
    error: null
}

const favoritesSlice = createSlice({
    name: 'favorites',
    initialState: initialState,
    reducers: {
        //Favorilere ürün eklemek için kullanılır. Eğer ürün zaten favorilerde varsa tekrar eklenmez.
        AddToFavorites: (state, action) => {
            let { productId } = action.payload;
            state.products.unshift({productId})
            console.log('state.favorites: ', state.favorites);
        },
        showInFavorites: (state, action) => {
            //Favorilerde görünen ürünleri eklemek için kullanılır.
            let { product, count, size } = action.payload;
            console.log('action.payload: ', action.payload);
            state.products.push({
                ...product,
                count: count, 
                size: size
            })
        },
        removeFromFavorites: (state, action) => {
            //Favorilerden belirli bir ürünü kaldırır.

            let { productId, size } = action.payload;
            console.log('state.products: ', state.products);
            let filteredCart = state.products.filter(item => !(item.size === size && item.productId === productId))
            state.products= filteredCart
        },
        //sepeti comple silmek için
        clearFavorites: (state) => {
            //Favorileri komple temizler.
            state.products = []
        },
    },
    extraReducers(builder) {
        builder
          .addCase(getFavorites.pending, (state, action) => {
            state.status = 'loading'
          })
          .addCase(getFavorites.fulfilled, (state, action) => {
            // Add any fetched posts to the array
            const {favorites, products} = action.payload
            state.products = favorites.map(item => {

                const product = products.find(product => product.productId === item.productId)
                return (
                    {
                        ...product,
                    }
                )
            });
          })
          .addCase(getFavorites.rejected, (state, action) => {
            state.status = 'failed'
            state.error = action.error.message
          })
          .addCase(addToFavorites.fulfilled, (state, action) => {
            state.status = 'succeeded'
            // Add any fetched posts to the array
            const {productId, products} = action.payload;
            const product = products.find(product => product.productId === productId);
                state.products.unshift ({
                    ...product
                })
            })
          .addCase(removeFromFavorites.fulfilled, (state, action) => {
            const {productId, products} = action.payload;
            state.products = state.products.filter(prod => prod.productId !== productId); 
            });
      }
})
export default favoritesSlice.reducer
export const selectAllFavorites = state => state.favorites.products;

export function addToCart(id, size, count) {
    return async (dispatch, getState) => {
        // you can use api and something else here
        const state = getState();
        let product = null;
        const user = await userManager.getUser();
        if (!user) {
            Swal.fire(
                {
                    title: 'Üye Girişi',
                    text: "Lütfen üye girişi yapınız!",
                    icon: 'warning',
                    showConfirmButton: true
                }
            )
            return;
            }

        if (state.products.singleProduct?.productId === id) {
            product = state.products.singleProduct
        }
        else {
            product = state.products.products.find(prod => prod.productId === id)
        }

        const success = await HttpService.addToCart(id, size, count)

        if (success) {
            dispatch({ type: "cart/AddToCart", payload: { product: product, count: count, size: size } })
        }
        else {
            Swal.fire(
                {
                    title: 'Başarısız oldum...',
                    text: "Ürün sepete eklenemedi :(",
                    icon: 'error',
                    showConfirmButton: false,
                    timer: 2000
                }
            )
        }
    }
  }

export const getFavorites = createAsyncThunk('favorites/getFavorites', async () => {  
    // Favori bilgilerini asenkron olarak getiren bir fonksiyondur.
        const data = await HttpService.getFavorites();
        const products = await HttpService.getAllProducts();
        return {favorites: data, products: products}
})

export const addToFavorites = createAsyncThunk('favorites/addToFavorites', async (product_id) => {
    //Favorilere ürün eklemek için kullanılan bir async action creator.
        const data = await HttpService.addToFavorites(product_id);
        const products = await HttpService.getAllProducts();
        return {productId: product_id, products: products}
})

export const removeFromFavorites = createAsyncThunk('favorites/removeFromFavorites', async (productId) => {
    //Favorilerden ürün silmek için kullanılan bir async action 
        const data = await HttpService.removeFromFavorites(productId);
        const products = await HttpService.getAllProducts();
        return {productId, products: products}
})


