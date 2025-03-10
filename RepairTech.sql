PGDMP      9                |         
   RepairTech    16.2    16.2 <    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    17970 
   RepairTech    DATABASE     �   CREATE DATABASE "RepairTech" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "RepairTech";
                postgres    false            �            1259    18066    akun    TABLE     �   CREATE TABLE public.akun (
    id_akun integer NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(255) NOT NULL,
    role character varying(50) NOT NULL,
    email character varying(100) NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false            �            1259    18069    akun_id_akun_seq    SEQUENCE     �   CREATE SEQUENCE public.akun_id_akun_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.akun_id_akun_seq;
       public          postgres    false    227            �           0    0    akun_id_akun_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.akun_id_akun_seq OWNED BY public.akun.id_akun;
          public          postgres    false    228            �            1259    18028    detail_komponen    TABLE     �   CREATE TABLE public.detail_komponen (
    id_detail_komponen integer NOT NULL,
    id_transaksi integer,
    id_komponen integer,
    harga numeric(10,2),
    jumlah integer
);
 #   DROP TABLE public.detail_komponen;
       public         heap    postgres    false            �            1259    18027 &   detail_komponen_id_detail_komponen_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_komponen_id_detail_komponen_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 =   DROP SEQUENCE public.detail_komponen_id_detail_komponen_seq;
       public          postgres    false    224            �           0    0 &   detail_komponen_id_detail_komponen_seq    SEQUENCE OWNED BY     q   ALTER SEQUENCE public.detail_komponen_id_detail_komponen_seq OWNED BY public.detail_komponen.id_detail_komponen;
          public          postgres    false    223            �            1259    18045    detail_transaksi    TABLE     �   CREATE TABLE public.detail_transaksi (
    id_detail_transaksi integer NOT NULL,
    id_transaksi integer,
    id_jasa_perbaikan integer,
    biaya numeric(10,2)
);
 $   DROP TABLE public.detail_transaksi;
       public         heap    postgres    false            �            1259    18044 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_transaksi_id_detail_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ?   DROP SEQUENCE public.detail_transaksi_id_detail_transaksi_seq;
       public          postgres    false    226            �           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE OWNED BY     u   ALTER SEQUENCE public.detail_transaksi_id_detail_transaksi_seq OWNED BY public.detail_transaksi.id_detail_transaksi;
          public          postgres    false    225            �            1259    18001    jasa_perbaikan    TABLE     �   CREATE TABLE public.jasa_perbaikan (
    id_jasa_perbaikan integer NOT NULL,
    jenis_kerusakan character varying(50) NOT NULL,
    solusi character varying(100) NOT NULL,
    biaya numeric(10,2) NOT NULL,
    estimasi_waktu integer NOT NULL
);
 "   DROP TABLE public.jasa_perbaikan;
       public         heap    postgres    false            �            1259    18000 $   jasa_perbaikan_id_jasa_perbaikan_seq    SEQUENCE     �   CREATE SEQUENCE public.jasa_perbaikan_id_jasa_perbaikan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ;   DROP SEQUENCE public.jasa_perbaikan_id_jasa_perbaikan_seq;
       public          postgres    false    218            �           0    0 $   jasa_perbaikan_id_jasa_perbaikan_seq    SEQUENCE OWNED BY     m   ALTER SEQUENCE public.jasa_perbaikan_id_jasa_perbaikan_seq OWNED BY public.jasa_perbaikan.id_jasa_perbaikan;
          public          postgres    false    217            �            1259    17994    komponen    TABLE     �   CREATE TABLE public.komponen (
    id_komponen integer NOT NULL,
    nama_komponen character varying(50) NOT NULL,
    harga numeric(10,2) NOT NULL,
    stok integer NOT NULL
);
    DROP TABLE public.komponen;
       public         heap    postgres    false            �            1259    17993    komponen_id_komponen_seq    SEQUENCE     �   CREATE SEQUENCE public.komponen_id_komponen_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.komponen_id_komponen_seq;
       public          postgres    false    216            �           0    0    komponen_id_komponen_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.komponen_id_komponen_seq OWNED BY public.komponen.id_komponen;
          public          postgres    false    215            �            1259    18008    teknisi    TABLE        CREATE TABLE public.teknisi (
    id_teknisi integer NOT NULL,
    nama character varying(50) NOT NULL,
    keahlian character varying(50) NOT NULL,
    jam_kerja character varying(50) NOT NULL,
    alamat character varying(100) NOT NULL,
    no_telepon character varying(20) NOT NULL
);
    DROP TABLE public.teknisi;
       public         heap    postgres    false            �            1259    18007    teknisi_id_teknisi_seq    SEQUENCE     �   CREATE SEQUENCE public.teknisi_id_teknisi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.teknisi_id_teknisi_seq;
       public          postgres    false    220            �           0    0    teknisi_id_teknisi_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.teknisi_id_teknisi_seq OWNED BY public.teknisi.id_teknisi;
          public          postgres    false    219            �            1259    18016 	   transaksi    TABLE     ?  CREATE TABLE public.transaksi (
    id_transaksi integer NOT NULL,
    tanggal date NOT NULL,
    laptop character varying(50),
    id_teknisi integer,
    alamat character varying(255),
    status_transaksi character varying(20) DEFAULT 'Belum Selesai'::character varying,
    nama_pelanggan character varying(255)
);
    DROP TABLE public.transaksi;
       public         heap    postgres    false            �            1259    18015    transaksi_id_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.transaksi_id_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transaksi_id_transaksi_seq;
       public          postgres    false    222                        0    0    transaksi_id_transaksi_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transaksi_id_transaksi_seq OWNED BY public.transaksi.id_transaksi;
          public          postgres    false    221            ?           2604    18070    akun id_akun    DEFAULT     l   ALTER TABLE ONLY public.akun ALTER COLUMN id_akun SET DEFAULT nextval('public.akun_id_akun_seq'::regclass);
 ;   ALTER TABLE public.akun ALTER COLUMN id_akun DROP DEFAULT;
       public          postgres    false    228    227            =           2604    18071 "   detail_komponen id_detail_komponen    DEFAULT     �   ALTER TABLE ONLY public.detail_komponen ALTER COLUMN id_detail_komponen SET DEFAULT nextval('public.detail_komponen_id_detail_komponen_seq'::regclass);
 Q   ALTER TABLE public.detail_komponen ALTER COLUMN id_detail_komponen DROP DEFAULT;
       public          postgres    false    224    223    224            >           2604    18072 $   detail_transaksi id_detail_transaksi    DEFAULT     �   ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN id_detail_transaksi SET DEFAULT nextval('public.detail_transaksi_id_detail_transaksi_seq'::regclass);
 S   ALTER TABLE public.detail_transaksi ALTER COLUMN id_detail_transaksi DROP DEFAULT;
       public          postgres    false    226    225    226            9           2604    18073     jasa_perbaikan id_jasa_perbaikan    DEFAULT     �   ALTER TABLE ONLY public.jasa_perbaikan ALTER COLUMN id_jasa_perbaikan SET DEFAULT nextval('public.jasa_perbaikan_id_jasa_perbaikan_seq'::regclass);
 O   ALTER TABLE public.jasa_perbaikan ALTER COLUMN id_jasa_perbaikan DROP DEFAULT;
       public          postgres    false    218    217    218            8           2604    18074    komponen id_komponen    DEFAULT     |   ALTER TABLE ONLY public.komponen ALTER COLUMN id_komponen SET DEFAULT nextval('public.komponen_id_komponen_seq'::regclass);
 C   ALTER TABLE public.komponen ALTER COLUMN id_komponen DROP DEFAULT;
       public          postgres    false    216    215    216            :           2604    18075    teknisi id_teknisi    DEFAULT     x   ALTER TABLE ONLY public.teknisi ALTER COLUMN id_teknisi SET DEFAULT nextval('public.teknisi_id_teknisi_seq'::regclass);
 A   ALTER TABLE public.teknisi ALTER COLUMN id_teknisi DROP DEFAULT;
       public          postgres    false    219    220    220            ;           2604    18076    transaksi id_transaksi    DEFAULT     �   ALTER TABLE ONLY public.transaksi ALTER COLUMN id_transaksi SET DEFAULT nextval('public.transaksi_id_transaksi_seq'::regclass);
 E   ALTER TABLE public.transaksi ALTER COLUMN id_transaksi DROP DEFAULT;
       public          postgres    false    222    221    222            �          0    18066    akun 
   TABLE DATA           H   COPY public.akun (id_akun, username, password, role, email) FROM stdin;
    public          postgres    false    227   �J       �          0    18028    detail_komponen 
   TABLE DATA           g   COPY public.detail_komponen (id_detail_komponen, id_transaksi, id_komponen, harga, jumlah) FROM stdin;
    public          postgres    false    224   �K       �          0    18045    detail_transaksi 
   TABLE DATA           g   COPY public.detail_transaksi (id_detail_transaksi, id_transaksi, id_jasa_perbaikan, biaya) FROM stdin;
    public          postgres    false    226   L       �          0    18001    jasa_perbaikan 
   TABLE DATA           k   COPY public.jasa_perbaikan (id_jasa_perbaikan, jenis_kerusakan, solusi, biaya, estimasi_waktu) FROM stdin;
    public          postgres    false    218   gL       �          0    17994    komponen 
   TABLE DATA           K   COPY public.komponen (id_komponen, nama_komponen, harga, stok) FROM stdin;
    public          postgres    false    216   �M       �          0    18008    teknisi 
   TABLE DATA           \   COPY public.teknisi (id_teknisi, nama, keahlian, jam_kerja, alamat, no_telepon) FROM stdin;
    public          postgres    false    220   N       �          0    18016 	   transaksi 
   TABLE DATA           x   COPY public.transaksi (id_transaksi, tanggal, laptop, id_teknisi, alamat, status_transaksi, nama_pelanggan) FROM stdin;
    public          postgres    false    222   O                  0    0    akun_id_akun_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.akun_id_akun_seq', 20, true);
          public          postgres    false    228                       0    0 &   detail_komponen_id_detail_komponen_seq    SEQUENCE SET     U   SELECT pg_catalog.setval('public.detail_komponen_id_detail_komponen_seq', 12, true);
          public          postgres    false    223                       0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public.detail_transaksi_id_detail_transaksi_seq', 29, true);
          public          postgres    false    225                       0    0 $   jasa_perbaikan_id_jasa_perbaikan_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.jasa_perbaikan_id_jasa_perbaikan_seq', 13, true);
          public          postgres    false    217                       0    0    komponen_id_komponen_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.komponen_id_komponen_seq', 19, true);
          public          postgres    false    215                       0    0    teknisi_id_teknisi_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.teknisi_id_teknisi_seq', 4, true);
          public          postgres    false    219                       0    0    transaksi_id_transaksi_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.transaksi_id_transaksi_seq', 41, true);
          public          postgres    false    221            M           2606    18078    akun akun_email_key 
   CONSTRAINT     O   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_email_key UNIQUE (email);
 =   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_email_key;
       public            postgres    false    227            O           2606    18080    akun akun_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_pkey PRIMARY KEY (id_akun);
 8   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_pkey;
       public            postgres    false    227            Q           2606    18082    akun akun_username_key 
   CONSTRAINT     U   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_key UNIQUE (username);
 @   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_username_key;
       public            postgres    false    227            I           2606    18033 $   detail_komponen detail_komponen_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public.detail_komponen
    ADD CONSTRAINT detail_komponen_pkey PRIMARY KEY (id_detail_komponen);
 N   ALTER TABLE ONLY public.detail_komponen DROP CONSTRAINT detail_komponen_pkey;
       public            postgres    false    224            K           2606    18050 &   detail_transaksi detail_transaksi_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi);
 P   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_pkey;
       public            postgres    false    226            C           2606    18006 "   jasa_perbaikan jasa_perbaikan_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.jasa_perbaikan
    ADD CONSTRAINT jasa_perbaikan_pkey PRIMARY KEY (id_jasa_perbaikan);
 L   ALTER TABLE ONLY public.jasa_perbaikan DROP CONSTRAINT jasa_perbaikan_pkey;
       public            postgres    false    218            A           2606    17999    komponen komponen_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.komponen
    ADD CONSTRAINT komponen_pkey PRIMARY KEY (id_komponen);
 @   ALTER TABLE ONLY public.komponen DROP CONSTRAINT komponen_pkey;
       public            postgres    false    216            E           2606    18013    teknisi teknisi_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.teknisi
    ADD CONSTRAINT teknisi_pkey PRIMARY KEY (id_teknisi);
 >   ALTER TABLE ONLY public.teknisi DROP CONSTRAINT teknisi_pkey;
       public            postgres    false    220            G           2606    18021    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public            postgres    false    222            S           2606    18039 0   detail_komponen detail_komponen_id_komponen_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_komponen
    ADD CONSTRAINT detail_komponen_id_komponen_fkey FOREIGN KEY (id_komponen) REFERENCES public.komponen(id_komponen) ON DELETE CASCADE;
 Z   ALTER TABLE ONLY public.detail_komponen DROP CONSTRAINT detail_komponen_id_komponen_fkey;
       public          postgres    false    216    4673    224            T           2606    18034 1   detail_komponen detail_komponen_id_transaksi_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_komponen
    ADD CONSTRAINT detail_komponen_id_transaksi_fkey FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi) ON DELETE CASCADE;
 [   ALTER TABLE ONLY public.detail_komponen DROP CONSTRAINT detail_komponen_id_transaksi_fkey;
       public          postgres    false    224    4679    222            U           2606    18061 8   detail_transaksi detail_transaksi_id_jasa_perbaikan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_jasa_perbaikan_fkey FOREIGN KEY (id_jasa_perbaikan) REFERENCES public.jasa_perbaikan(id_jasa_perbaikan) ON DELETE CASCADE;
 b   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_jasa_perbaikan_fkey;
       public          postgres    false    226    218    4675            V           2606    18051 3   detail_transaksi detail_transaksi_id_transaksi_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_transaksi_fkey FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi) ON DELETE CASCADE;
 ]   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_transaksi_fkey;
       public          postgres    false    222    4679    226            R           2606    18127    transaksi fk_id_teknisi    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT fk_id_teknisi FOREIGN KEY (id_teknisi) REFERENCES public.teknisi(id_teknisi) ON DELETE SET NULL;
 A   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT fk_id_teknisi;
       public          postgres    false    4677    222    220            �   �   x�m�A�0���1��Ջ�^*L��"���m*Mƚ�ޗ�����v@��j��pi�u˶����`��"r5��,�p3�	��dŬ�7]���
ױ�����T��S<����pF�{�xG���i�O󗃴�]XB��8H���z�%�[/@4R!]~�J�pW�O]�6F�8��t�4�Im~�h+2��`�Õ��o[��">&��      �   C   x�M���0�o��k��.�?�WS�|�D?1�*M����҇A�����_����j�ݍ��Qq      �   ;   x�M˹  ���va�9xbw'[p�4fҼr�����O��߄��V#��G      �   @  x�e��n�0����4��s����H$꥗Eޒ� cZ��kRC����o<3f;:WZ-����������rCM�&� )d��"('S��+�^�v�oHsYn�;������/k/h"�<ڻ��o_d���M9�*�O�<8:ɂ��36�V'�C�6dW^��^H���K�<}��1	�t�R���:y(����<S���r��gHEs���˺����8�<�h�������߆�	���&G�R�%�baކ��R�;�<��­��;=���.F	��Ar��|���*��۷^�}ߞW�O">6B�5��?      �   �   x�M��
�0E�3_1_ ���dY�BK�v�M(������#>fy�{�<Owbs.���2!@#34MMRϢ�Kd��f�Md��&~�
d������sd7��Xg��ӧ?�Eo���6��U�8�>�ٴ[�R��!�i�<a�J<�.�.�4��%dU�C�z��&?B�{�.u�إ�3D��|A<      �   ~   x�3�H�����O+)O,J�40�30P�U04ҜN�y���y陜\ƜA��e�y)H���tA�8}S2K�*�8=��8=�R0U��&����p�%�&&�"T�Y����_�_R���� Ȅ/�      �   �   x�m���0E����?��R�qp0h����žH��I�z��hr�sNr�5�T�$�IZ@�-�f�ȑz�i�H�a7�B��;Y8�<�7�b����jv�}�=ݺh�P�K�b� *���A����Zq�ԏf&T���3�cCC������
��@@�     