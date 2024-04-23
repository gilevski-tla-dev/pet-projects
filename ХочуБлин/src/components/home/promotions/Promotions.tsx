import { useEffect, useState } from 'react'
import PromotionItem from './promotion-item/PromotionItem'
import styles from './promotions.module.css'
import { IData } from 'src/interface.i'
import Marquee from 'react-fast-marquee'

const data: IData[] = [
    {
        id: 1,
        title: 'Акция до 30.01',
        text: 'С 8:00-11.30 Утреннее комбо (кофе, панкейки с люой начинкой) всего за 279 р.',
        img_src: '/poster.png',
        // color: {
        //     bg: '#022A2D',
        //     ui: '#FFE500',
        //     text: '#022A2D',
        // },
    },
    {
        id: 2,
        img_src: '/poster.png',
        text: 'С 8:00-11.30 Утреннее комбо (кофе, панкейки с люой начинкой) всего за 279 р.',
        title: 'Акция до 30.01',
        // color: {
        //     ui: '#DDC4FE',
        //     bg: '#0B1149',
        //     text: '#390E00',
        // },
    },
    {
        id: 3,
        img_src: '/poster.png',
        text: 'С 8:00-11.30 Утреннее комбо (кофе, панкейки с люой начинкой) всего за 279 р.',
        title: 'Акция до 30.01',
        // color: {
        //     ui: '#FFDCC8',
        //     bg: '#501616',
        //     text: '#501616',
        // },
    },
]

const Promotions = () => {
    const [windowWidth, setWindowWidth] = useState(window.innerWidth)

    useEffect(() => {
        const handleResize = () => setWindowWidth(window.innerWidth)
        window.addEventListener('resize', handleResize)
        return () => window.removeEventListener('resize', handleResize)
    }, [])

    return (
        <div className={styles.wrapper}>
            {data.length == 1 && (
                <div className={`${styles.content} ${styles.center_item}`}>
                    <PromotionItem {...data[0]} />
                </div>
            )}
            {data.length == 2 && windowWidth >= 1480 && (
                <div className={`${styles.content} ${styles.center_item}`}>
                    {data.map((item, i) => (
                        <PromotionItem key={i} {...item} />
                    ))}
                </div>
            )}
            {((data.length > 1 && windowWidth < 1480) || data.length > 2) && (
                <div className={styles.marquee_wrapper}>
                    <div className={styles.marquee_content}>
                        <Marquee pauseOnClick speed={60} className={styles.content}>
                            {data.map((item, i) => (
                                <PromotionItem key={i} {...item} />
                            ))}
                        </Marquee>
                    </div>
                </div>
            )}
        </div>
    )
}

export default Promotions
