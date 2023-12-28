import { createSlice } from "@reduxjs/toolkit";
import userManager from "../../utils/userManager";

// Bu dosya, kullanıcıyla ilgili durumları yönetir ve kullanıcının giriş, çıkış veya kayıt olma gibi eylemlerine tepki verir. 
// Bu durumları güncelleyerek, uygulamanın farklı bölümlerinde kullanıcının durumunu izlemek ve kullanıcıya özgü 
// içerikleri yönetmek mümkün olur.

const userSlice = createSlice({
    name: 'user',
    initialState: {
        loggedIn: false,
        status: false,
        user: {}
    },
    reducers: {
        login: (state, action) => {
            //Kullanıcının giriş yapmasını temsil eder. status ve loggedIn değerlerini, 
            //giriş durumunu belirten action.payload.status değeriyle günceller. 
            //Ayrıca, kullanıcının verilerini içeren action.payload.user ile user alanını günceller.

            state.status = action.payload.status
            state.loggedIn = action.payload.status
            state.user = action.payload.user
        },
        register: (state, action) => {
            //Kullanıcının kayıt olmasını temsil eder. 
            //status değerini true olarak ayarlar ve user alanına, kayıt olan kullanıcının bilgilerini ekler.

            let { name, email, pass } = action.payload;
            state.status = true
            state.user = {
                name: name,
                role: 'customer',
                email: email,
                pass: pass
            }
        },
        logout: (state) => {
            //Kullanıcının çıkış yapmasını temsil eder. status ve loggedIn değerlerini false olarak ayarlar. 
            //Ayrıca, user alanını boş bir nesneyle sıfırlar. Kullanıcının çıkış yapması durumunda, 
            //userManager.removeUser() fonksiyonu çağrılarak kullanıcının bilgileri temizlenir.

            userManager.removeUser()
                .then(data => {})
                .catch(error => {
                    console.error("Cannot log out!", error)
                })

            console.log("user slice logouta gelindi");
            state.status = false;
            state.loggedIn = false;
            state.user = {}
        }
    }
})

const userReducer = userSlice.reducer
export default userReducer

export const userIsLoggedIn = state => state.user.loggedIn  
//Bu fonksiyon genellikle, uygulamanın herhangi bir yerinde 
//kullanıcının giriş yapmış olup olmadığını kontrol etmek için kullanılır.
