import React, {lazy,Suspense} from "react";

const loadable = (importFunc, {fallback = null} = {fallback :null}) => {
    const LazyComponent = lazy(importFunc);
    return props => 
    <Suspense fallback= {fallback}>
        <LazyComponent {...props} />  
    </Suspense>
}

export default loadable

// kodu bölerek uygulama yüklenirken daha iyi bir performans elde etmek için kullanılan 
// tembel yükleme yöntemini uygulamak için tasarlanmış bir yardımcı işlev sunar.

// Suspense bileşeni, tembel yüklenen bileşen yüklenene kadar gösterilecek yedek içerik için kullanılır.
// Dinamik olarak yüklenen bileşen, <LazyComponent {...props} /> şeklinde kullanılır.